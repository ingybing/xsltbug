using System;

using UIKit;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Text;

namespace xsltbug
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton6_TouchUpInside (UIButton sender)
		{
			var xslt = new XslCompiledTransform();

			using (var stringReader = new StringReader(txtXslt.Text))
			{
				using(var xmlReader = XmlReader.Create(stringReader))
				{
					xslt.Load(xmlReader);
				}
			}

			using (var stringReader = new StringReader(txtXml.Text))
			{
				using (var xmlreader = XmlReader.Create(stringReader))
				{
					try
					{
						var stringBuilder = new StringBuilder();
						using (var xmlWriter = XmlWriter.Create(stringBuilder))
						{
							xslt.Transform(xmlreader, xmlWriter);
						}
						txtResult.Text = stringBuilder.ToString();
					}
					catch(Exception ex)
					{
						txtResult.Text = ex.Message;
					}
				}
			}

			

		}
	}
}

