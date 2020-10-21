using System;
using System.Speech.Recognition;
using Verse;

namespace VoiceActivatedAtrocities {
    class VoiceControllerComp : GameComponent {
        private SpeechRecognitionEngine recognitionEngine;
        public override void FinalizeInit() {
            InitializeVoiceRecognition();
        }

        public VoiceControllerComp(Game game) {
        }

        public override void GameComponentUpdate() {
            //recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void InitializeVoiceRecognition() {
            //recognitionEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
           /* Choices targetAs = new Choices();
            targetAs.Add(new string[] { "kill", "Remove", "Drink", "eat" });
            Choices targetBs = new Choices();
            targetBs.Add(new string[] { "someone", "joe", "pirates", "Jeremy", "Darkshot", "Darkshot's" });
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(targetAs);
            builder.Append(targetBs);
            Grammar grammar = new Grammar(builder);
            grammar.Name = "Choices";

            DictationGrammar DictationGrammar = new DictationGrammar("grammar:dictation");
            DictationGrammar.Name = "DictationGrammar";
    
            recognitionEngine.LoadGrammarAsync(grammar);
            recognitionEngine.LoadGrammarAsync(DictationGrammar);
            recognitionEngine.SetInputToDefaultAudioDevice();
            recognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(HandleRecognitionEvent);*/
        }

        private void HandleRecognitionEvent(object sender, SpeechRecognizedEventArgs e) {
            Log.Message("Recognized text: " + e.Result.Text);
        }
    }
}
