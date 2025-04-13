namespace DLWMS.WinApp.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control control, ErrorProvider err, string poruka)
        {
            bool validanUnos = true;
            
            if (control is PictureBox pictureBox && pictureBox.Image == null)
                validanUnos = false;
            else if (control is ComboBox comboBox && comboBox.SelectedIndex<0)
                validanUnos = false;
            else if(control is TextBox textBox && !textBox.Text.IsSet())
                validanUnos = false;

            if (!validanUnos)
            {
                err.SetError(control, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
