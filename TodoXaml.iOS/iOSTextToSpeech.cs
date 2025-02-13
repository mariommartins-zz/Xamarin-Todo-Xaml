using AVFoundation;
using TodoXaml;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSTextToSpeech))]

namespace TodoXaml
{
    public class iOSTextToSpeech : ITextToSpeech
	{
		float volume = 0.5f;
		float pitch = 1.0f;
		/// <summary>
		/// Speak example from: 
		/// http://blog.xamarin.com/make-your-ios-7-app-speak/
		/// </summary>
		public void Speak (string text)
		{
			var speechSynthesizer = new AVSpeechSynthesizer ();

			var speechUtterance = new AVSpeechUtterance (text) {
				Rate = AVSpeechUtterance.MaximumSpeechRate/4,
				Voice = AVSpeechSynthesisVoice.FromLanguage ("en-US"),
				Volume = volume,
				PitchMultiplier = pitch
			};

			speechSynthesizer.SpeakUtterance (speechUtterance);
		}
	}
}

