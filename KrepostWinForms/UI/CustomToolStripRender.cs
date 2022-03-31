namespace KrepostWinForms.UI
{
    // Taken from https://stackoverflow.com/questions/8527585/how-to-remove-this-strange-visual-artifact-in-the-corner-of-toolstrip-winforms-c
    internal class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomToolStripRenderer() : base(new CustomColorTable())
        {

        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // Prevent default distorted border from being rendered.
        }
    }
}
