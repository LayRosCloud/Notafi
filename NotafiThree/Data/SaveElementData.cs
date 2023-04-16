using NotafiThree.Model.PersonalityData;

namespace NotafiThree.Data
{
    internal class SaveElementData
    {
        private static User _userInstance;
        public static User UserIntance
        {
            get => _userInstance;
            set
            {
                _userInstance = value;
            }
        }
    }
}
