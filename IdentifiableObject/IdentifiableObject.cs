namespace SwinAdventure

{
    public class IdentifiableObject
    {
        private List<string> _identifiers = [];

        public IdentifiableObject(string[] identifiers)
        {
            foreach (string i in identifiers)
            {
                _identifiers.Add(i.ToLower());
            }

        }
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        public string FirstId()
        {
            if (_identifiers.Count() == 0) return "";
            return _identifiers[0];
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public void RemoveIdentifier(string id)
        {
            _identifiers.Remove(id.ToLower());
        }

        public void PrivilegeEscalation(string pin)
        {
            if (pin == "3500")
            {

                _identifiers[0] = "Class tuesday afternoon";
            }
        }
    }

}