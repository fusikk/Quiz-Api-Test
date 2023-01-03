using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public static class Extensions
    {
        [Flags]
        public enum Panels
        {
            MainMenu,
            Questions,
            QuizSummary
        }
        
        /// <summary>
        /// <c>Color</c> to use when highlighting.
        /// </summary>
        private static Color HighLightColor = Color.BlueViolet;

        private static Color BackColor = Color.DarkGreen;
        
        [Obsolete("Use GetAllControlsOfType<T>() instead.")]
        public static IEnumerable<Control> GetControlsOfType(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.Where(ctrl => ctrl.GetType() == type);
        }

        /// <summary>
        /// Highlights a button.
        /// </summary>
        /// <param name="forced">Force the highlight. Omit if you want to switch the highlight.</param>
        public static void Highlight(Control button, bool forced)
        {
            if (forced)
            {
                button.BackColor = HighLightColor;
            }
            else
            {
                button.BackColor = BackColor;
            }
        }

        /// <summary>
        /// Highlights a button.
        /// </summary>
        public static void Highlight(Control button)
        {
            Highlight(button, button.BackColor != HighLightColor);
        }

        /// <summary>
        /// Search all controls of <c>parent</c> for children of type <c>T</c>
        /// </summary>
        /// <param name="recursive">Whether the search should be recursive.</param>
        /// <returns>List of controls of type <c>T</c></returns>
        public static IList<T> GetAllControlsOfType<T>(Control parent, bool recursive) where T : Control
        {
            //TODO: Unit tests
            var result = new List<T>();

            foreach (Control control in parent.Controls)
            {
                var controlAfterCast = control as T;

                if (controlAfterCast != null)
                {
                    result.Add(controlAfterCast);
                }

                if (recursive && control.Controls.Count > 0)
                    result = result.Concat(GetAllControlsOfType<T>(control, true)).ToList();
            }

            return result;
        }
    }
}
