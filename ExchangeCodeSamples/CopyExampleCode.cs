
namespace ExchangeCodeSamples
{


    public class ExampleCode
    {


        public static void Copy()
        {
            string targetDir = @"D:\username\Documents\Visual Studio 2017\Projects\ews-managed-api\ExchangeCodeSamples\Examples";

            string dir = @"D:\username\Downloads\Exchange 2013 101 Code Samples";

            string[] baseDirz = System.IO.Directory.GetDirectories(dir, "Exchange*", System.IO.SearchOption.TopDirectoryOnly);

            foreach (string baseDir in baseDirz)
            {
                string[] projDirz = System.IO.Directory.GetDirectories(baseDir, "Ex*", System.IO.SearchOption.AllDirectories);
                if (projDirz.Length > 1)
                    System.Console.WriteLine(projDirz);

                foreach (string projDir in projDirz)
                {
                    string[] filez = System.IO.Directory.GetFiles(projDir, "Ex15_*.cs");
                    if (filez.Length > 1)
                        System.Console.WriteLine(filez);

                    foreach (string file in filez)
                    {
                        System.Console.WriteLine(file);
                        string fileName = System.IO.Path.GetFileName(file);
                        if (fileName.StartsWith("Ex15_", System.StringComparison.OrdinalIgnoreCase))
                            fileName = fileName.Substring("Ex15_".Length);
                        else
                            System.Console.WriteLine("argh");

                        string target = System.IO.Path.Combine(targetDir, fileName);

                        System.IO.File.Copy(file, target, true);
                    } // Next file 

                } // Next projDir 

            } // Next baseDir 

            System.Console.WriteLine("finished");
        } // End Sub Copy 


    } // End Class ExampleCode 


} // End Namespace ExchangeCodeSamples
