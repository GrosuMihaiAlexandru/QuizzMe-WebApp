using Microsoft.JSInterop;

namespace QuizMe.Utility
{
    public class SoundPlayer : ISoundPlayer
    {
        private readonly IJSRuntime _jsRuntime;
        private const string JSFUNCTION = "playaudio";

        public SoundPlayer(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task Play(string sound)
        {
            if (string.IsNullOrEmpty(sound))
                return;
            await _jsRuntime.InvokeVoidAsync(JSFUNCTION, sound);
        }
    }
}
