
namespace Titanium.Web.Proxy.Examples.Basic
{


    public class ProxyServerProgram 
    {

        public static bool Certificate_NoValidation_CallBack(
           object sender,
           System.Security.Cryptography.X509Certificates.X509Certificate certificate,
           System.Security.Cryptography.X509Certificates.X509Chain chain,
           System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return CertificateValidationCallBack(sender, certificate, chain, sslPolicyErrors);
        }


        private static bool CertificateValidationCallBack(
            object sender,
            System.Security.Cryptography.X509Certificates.X509Certificate certificate,
            System.Security.Cryptography.X509Certificates.X509Chain chain,
            System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;

            // If the certificate is a valid, signed certificate, return true.
            if (sslPolicyErrors == System.Net.Security.SslPolicyErrors.None)
            {
                return true;
            }

            // If there are errors in the certificate chain, look at each error to determine the cause.
            if ((sslPolicyErrors & System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors) != 0)
            {
                if (chain != null && chain.ChainStatus != null)
                {
                    foreach (System.Security.Cryptography.X509Certificates.X509ChainStatus status in chain.ChainStatus)
                    {
                        if ((certificate.Subject == certificate.Issuer) &&
                            (status.Status == System.Security.Cryptography.X509Certificates.X509ChainStatusFlags
                                 .UntrustedRoot))
                        {
                            // Self-signed certificates with an untrusted root are valid. 
                            continue;
                        }
                        else if (status.Status == System.Security.Cryptography.X509Certificates.X509ChainStatusFlags
                                     .NotTimeValid)
                        {
                            // Ignore Expired certificates
                            continue;
                        }
                        else
                        {
                            if (status.Status != System.Security.Cryptography.X509Certificates.X509ChainStatusFlags
                                    .NoError)
                            {
                                // If there are any other errors in the certificate chain, the certificate is invalid,
                                // so the method returns false.
                                return false;
                            }
                        }
                    } // Next status 
                } // End if (chain != null && chain.ChainStatus != null) 

                // When processing reaches this line, the only errors in the certificate chain are 
                // untrusted root errors for self-signed certificates (, or expired certificates). 
                // These certificates are valid for default Exchange server installations, so return true.
                return true;
            } // End if ((sslPolicyErrors & System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors) != 0) 

            // In all other cases, return false.
            return false;
        } // End Function CertificateValidationCallBack 


        public static void InitializeSslTrust()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = CertificateValidationCallBack;
        }


        private static readonly ProxyTestController controller = new ProxyTestController();

        public static ProxyTestController Start()
        {
            // fix console hang due to QuickEdit mode
            // ConsoleHelper.DisableQuickEditMode();


            // InitializeSslTrust();

            // Start proxy controller
            controller.StartProxy();

            // MailSender.Test();

            controller.Stop();

            // System.Console.WriteLine(System.Environment.NewLine);
            // System.Console.WriteLine(" --- Press any key to continue --- ");
            // System.Console.ReadKey();

            return controller;
        }


    }


}
