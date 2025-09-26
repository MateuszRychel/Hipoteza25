namespace MauiApp6;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private int Nwd(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    }

    private void Alg(object sender, EventArgs e)
    {
        string input = textbox.Text;
        {
            int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            int wynik = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                wynik = Nwd(wynik, numbers[i]);
            }

            result.Text = wynik.ToString();
            SemanticScreenReader.Announce(result.Text);
        }
    }
}