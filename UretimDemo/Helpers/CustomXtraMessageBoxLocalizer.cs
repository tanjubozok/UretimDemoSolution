using DevExpress.XtraEditors.Controls;

namespace UretimDemo.Helpers
{
    public class CustomXtraMessageBoxLocalizer : Localizer
    {
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                case StringId.XtraMessageBoxYesButtonText:
                    return "Evet";
                case StringId.XtraMessageBoxNoButtonText:
                    return "Hayır";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
