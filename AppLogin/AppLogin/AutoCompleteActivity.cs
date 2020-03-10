
using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Text;
using Android.Widget;
using Java.Lang;

namespace AppLogin
{
    [Activity(Label = "AutoCompleteActivity",MainLauncher =true)]
    public class AutoCompleteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.autocompletetext);

            string[] cc = new string[] {
              "Afghanistan", "Albania", "Algeria","Zambia", "Zimbabwe"
            };


            AutoCompleteTextView textView = FindViewById<AutoCompleteTextView>(Resource.Id.autotextview);
            var adapter = new ArrayAdapter(this,Android.Resource.Layout.SimpleDropDownItem1Line, cc);
            textView.Adapter = adapter;
            textView.AddTextChangedListener(new TextWatch(this));
            textView.ItemClick += (s, e) =>
            {
                Toast.MakeText(this, "haha"+e.Position, ToastLength.Short).Show();
            };
        }

        private class TextWatch : Java.Lang.Object, ITextWatcher
        {
            private Activity _activity;
            public TextWatch(Activity activity)
            {
                _activity = activity;
            }

            public void AfterTextChanged(IEditable s)
            {
                //throw new NotImplementedException();
                //Toast.MakeText(_activity, "haha", ToastLength.Short).Show();
            }

            public void BeforeTextChanged(ICharSequence s, int start, int count, int after)
            {
                //throw new NotImplementedException();
            }

            public void OnTextChanged(ICharSequence s, int start, int before, int count)
            {
                //throw new NotImplementedException();
            }
        }
    }
}