using System;

namespace DesignPatterns.BehaviouralPatterns.State
{
    public class ModerationState : State
    {
        private Document _document;
        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
    
}