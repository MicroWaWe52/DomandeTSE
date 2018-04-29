using Android.App;
using Android.Content.Res;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace AppDomande
{
    [Activity(Label = "Domande TSE", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button buttonInvia;
        private EditText textboxDomanda;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager.DefaultDisplay.GetRealMetrics(displayMetrics);
            LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.layout1);
            layout.SetPadding(0,(displayMetrics.HeightPixels*30)/100,0,0);
            buttonInvia = FindViewById<Button>(Resource.Id.ButtonInvia);
            textboxDomanda = FindViewById<EditText>(Resource.Id.editTextDomanda);
            buttonInvia.Click += Button_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxDomanda.Text))
            {
                Toast.MakeText(this,"Inserisci una domanda",ToastLength.Long).Show();
            }
            else
            {
                Helper.Invia(textboxDomanda.Text);
                textboxDomanda.Text = "";
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.SetTitle("Domande TSE");
                builder.SetPositiveButton("Ok", delegate { });
                builder.SetMessage("La domanda è stata inviata");
                builder.SetCancelable(true);
                builder.Create().Show();
            }
      


        }
    }
}

