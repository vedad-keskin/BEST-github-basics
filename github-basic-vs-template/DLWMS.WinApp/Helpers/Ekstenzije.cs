using System.Drawing.Imaging;

namespace DLWMS.WinApp.Helpers
{
    public static class Ekstenzije
    {
        public static bool IsSet(this string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        public static byte[] ToByteArray(this Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image ToImage(this byte[] image)
        {
            return Image.FromStream(new MemoryStream(image));
        }

        public static object GetOdabraniRed(this DataGridView dataGridView)
        {
            if(dataGridView.SelectedRows.Count == 0)
                throw new Exception("Niste odabrali red!");
            return dataGridView.SelectedRows[0].DataBoundItem;         
        }

        public static void UcitajPodatke<T>(this ComboBox comboBox, List<T> dataSource,
            string displayMember = "Naziv", string valueMember = "Id")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = "Naziv";
            comboBox.ValueMember = "Id";
        }     
    }
}
