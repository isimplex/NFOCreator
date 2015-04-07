using System;
using System.Windows.Forms;
using System.Threading;

namespace NFOCreator
{
	public partial class MainForm : Form
	{
		private bool _canRun = true;
		private NFOCreator _nfo;
		private Thread _executeThread;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void CorrerClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(caminho.Text) && !string.IsNullOrWhiteSpace(tipo.Text)) 
            {
			    if (!_canRun) return;

			    _nfo = new NFOCreator(caminho.Text,tipo.Text);
					
			    _executeThread = new Thread(() =>
			    {
			        var count = _nfo.Run();
			        ShowMessageBox("Finished. " + count + " nfos were created");
			        _canRun = true;
			    });

			    ShowMessageBox("Start");
			    _executeThread.Start();
			    _canRun = false;
			} else {
				ShowMessageBox("Please fill all the fields");
			}
		}
		
		public void ShowMessageBox(string s){
			MessageBox.Show(s);
		}
	}
}