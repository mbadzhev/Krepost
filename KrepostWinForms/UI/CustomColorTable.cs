namespace KrepostWinForms.UI
{
    internal class CustomColorTable : ProfessionalColorTable
    {
        // Removes default gradient by using the same color for all three phases.
        public override Color ToolStripGradientBegin
        {
            get { return SystemColors.Control; }
        }

        public override Color ToolStripGradientMiddle
        {
            get { return SystemColors.Control; }
        }

        public override Color ToolStripGradientEnd
        {
            get { return SystemColors.Control; }
        }
    }
}
