namespace OnlineStore;

public partial class FormProducts : Form{
    private System.ComponentModel.IContainer components = null;

    private TextBox InputCountProducts = new TextBox();
    private TextBox InputNameProducts = new TextBox();

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Товары";
    }
    public FormProducts()
    {
        InitializeComponent();
    }
}