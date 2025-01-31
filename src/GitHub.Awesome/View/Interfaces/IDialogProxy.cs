﻿
using System.Threading.Tasks;

namespace GitHub.Awesome.View.Interfaces
{
    public interface IDialogProxy
    {
        /// <summary>
        /// Displays a native platform action sheet, allowing the application user to choose from several buttons.
        /// </summary>
        /// <param name="title">Title of the displayed action sheet. Must not be null.</param>
        /// <param name="cancel">Text to be displayed in the 'Cancel' button. Can be null to hide the cancel action.</param>
        /// <param name="destruction">Text to be displayed in the 'Destruct' button. Can be null to hide the destructive option.</param>
        /// <param name="buttons">Text labels for additional buttons. Must not be null.</param>
        /// <returns>An awaitable Task that displays an action sheet and returns the Text of the button pressed by the user.</returns>
        Task<string> DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons);

        /// <summary>
        //  Presents an alert dialog to the application user with a single cancel button.
        /// </summary>
        /// <param name="title">The title of the alert dialog.</param>
        /// <param name="message">The body text of the alert dialog.</param>
        /// <param name="cancel">Text to be displayed on the 'Cancel' button.</param>
        /// <returns></returns>
        Task DisplayAlert(string title, string message, string cancel);

        /// <summary>
        //  Presents an alert dialog to the application user with an accept and a cancel button.
        /// </summary>
        /// <param name="title">The title of the alert dialog.</param>
        /// <param name="message">The body text of the alert dialog.</param>
        /// <param name="accept">Text to be displayed on the 'Accept' button.</param>
        /// <param name="cancel">Text to be displayed on the 'Cancel' button.</param>
        /// <returns></returns>
        Task<bool> DisplayAlert(string title, string message, string accept, string cancel);
    }
}
