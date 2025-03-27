public static class PromptLoad
{
    public static string ShowDialog(string text, string caption, List<string> options, out bool deleteSelected)
    {
        Form prompt = new Form()
        {
            Width = 500,
            Height = 300,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };

        Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
        ComboBox comboBox = new ComboBox() { Left = 50, Top = 50, Width = 400 };
        comboBox.DataSource = options;
        Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 100, DialogResult = DialogResult.OK };
        Button deleteButton = new Button() { Text = "Delete", Left = 240, Width = 100, Top = 100, DialogResult = DialogResult.Abort };

        confirmation.Click += (sender, e) => { prompt.Close(); };
        deleteButton.Click += (sender, e) => { prompt.Close(); };

        prompt.Controls.Add(comboBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(deleteButton);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        var result = prompt.ShowDialog();
        deleteSelected = result == DialogResult.Abort;
        return result == DialogResult.OK || result == DialogResult.Abort ? comboBox.SelectedItem.ToString() : string.Empty;
    }
}
