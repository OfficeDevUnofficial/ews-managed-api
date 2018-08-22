
namespace System.Windows.Forms
{


    public enum DialogResult: int 
    {
        OK
    } 

    public class OpenFileDialog
    {

        public DialogResult ShowDialog()
        {
            return DialogResult.OK;
        }

        public System.IO.Stream OpenFile()
        {
            return null;
        }


        public string Filter { get; set; } = "All files (*.*)|*.*";
        public string InitialDirectory { get; set; } = "C:";
        public string Title { get; set; } = "Select an attachment";
        public int FilterIndex { get; set; } = 1;

        public string SafeFileName { get; set; }
        public string FileName { get; set; }

    }


}
