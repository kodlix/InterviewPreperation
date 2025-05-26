using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehaviouralPatterns.Momento
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }
        
        public void Backup()
        {
            _states.Add(_editor.CreateState());
        }
        
        public void Restore()
        {
            if (_states.Count == 0)
            {
                return;
            }

            EditorState prevState = _states.Last();
            _states.Remove(prevState);
            _editor.RestoreState(prevState);
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nHistory: Here's the list of momentos:");
            foreach (var state in _states)
            {
                Console.WriteLine(state.GetName());
            }
        }
    }
}