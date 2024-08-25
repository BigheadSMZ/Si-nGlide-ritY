namespace nGlideConfig
{
    internal class Translate
    {
        public static string VideoBackend(string Value)
        {
            switch (Value)
            {
                case "0": { return "Automatic"; }
                case "1": { return "DirectX"; }
                case "2": { return "Vulkan"; }
            }
            return "Automatic";
        }
        public static string Resolution(string Value)
        {
            switch (Value)
            {
                case "0":  { return "By Application"; }
                case "1":  { return "By Desktop"; }
                case "2":  { return "640x480"; }
                case "3":  { return "800x600"; }
                case "4":  { return "1024x600"; }
                case "5":  { return "1024x768"; }
                case "6":  { return "1152x864"; }
                case "7":  { return "1280x720"; }
                case "8":  { return "1280x768"; }
                case "9":  { return "1280x800"; }
                case "10": { return "1280x960"; }
                case "11": { return "1280x1024"; }
                case "12": { return "1360x768"; }
                case "13": { return "1366x768"; }
                case "14": { return "1400x1050"; }
                case "15": { return "1400x900"; }
                case "16": { return "1440x1080"; }
                case "17": { return "1536x864"; }
                case "18": { return "1600x900"; }
                case "19": { return "1600x1200"; }
                case "20": { return "1680x1050"; }
                case "21": { return "1920x1080"; }
                case "22": { return "1920x1200"; }
                case "23": { return "1920x1440"; }
                case "24": { return "2048x1536"; }
                case "25": { return "2560x1440"; }
                case "26": { return "2560x1600"; }
                case "27": { return "3840x2160"; }
                case "28": { return "7680x4320"; }
            }
            return "By Application";
        }
        public static string AspectRatio(string Value)
        {
            switch (Value)
            {
                case "0": { return "Entire Screen"; }
                case "1": { return "Aspect Correction"; }
                case "2": { return "Integer Rendering"; }
                case "3": { return "Integer Scaling"; }
            }
            return "Entire Screen";
        }
        public static string RefreshRate(string Value)
        {
            switch (Value)
            {
                case "0":  { return "By Application"; }
                case "1":  { return "By Desktop"; }
                case "2":  { return "60 Hertz"; }
                case "3":  { return "70 Hertz"; }
                case "4":  { return "72 Hertz"; }
                case "5":  { return "75 Hertz"; }
                case "6":  { return "85 Hertz"; }
                case "7":  { return "90 Hertz"; }
                case "8":  { return "100 Hertz"; }
                case "9":  { return "120 Hertz"; }
                case "10": { return "144 Hertz"; }
            }
            return "By Application";
        }
        public static string VerticalSync(string Value)
        {
            switch (Value)
            {
                case "0": { return "Off"; }
                case "1": { return "On"; }
            }
            return "On";
        }
        public static string GammaCorrection(string Value)
        {
            switch (Value)
            {
                case "0":  { return "0.5"; }
                case "1":  { return "0.6"; }
                case "2":  { return "0.7"; }
                case "3":  { return "0.8"; }
                case "4":  { return "0.9"; }
                case "5":  { return "1.0"; }
                case "6":  { return "1.1"; }
                case "7":  { return "1.2"; }
                case "8":  { return "1.3"; }
                case "9":  { return "1.4"; }
                case "10": { return "1.5"; }
            }
            return "1.0";
        }
        public static string SplashScreen(string Value)
        {
            switch (Value)
            {
                case "0": { return "Off"; }
                case "1": { return "On"; }
            }
            return "On";
        }
    }
}
