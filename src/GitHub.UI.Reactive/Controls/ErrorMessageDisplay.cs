﻿using System.Windows;
using System.Windows.Controls;
using NullGuard;

namespace GitHub.UI
{
    /// <summary>
    /// Customizable presenter of error messages.
    /// Accepts an error message, an icon as well as user provided content (useful for long form
    /// description of the error, potential remedies, links etc).
    /// See ErrorMessageDisplay.xaml for currently available styles.
    /// </summary>
    public class ErrorMessageDisplay : ContentControl
    {
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(ErrorMessageDisplay), new PropertyMetadata(""));

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Octicon), typeof(ErrorMessageDisplay), new PropertyMetadata(Octicon.stop));

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register("IconMargin", typeof(Thickness), typeof(ErrorMessageDisplay), new PropertyMetadata(new Thickness(0, 0, 4, 0)));

        /// <summary>
        /// Gets or sets the error message, treat this as the title.
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        /// <summary>
        /// Gets or sets an <see cref="Octicon"/> that may be used by the style if applicable.
        /// Defaults to <see cref="Octicon.stop"/>.
        /// </summary>
        public Octicon Icon
        {
            get { return (Octicon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public Thickness IconMargin
        {
            [return: AllowNull]
            get { return (Thickness)GetValue(IconMarginProperty); }
            set { SetValue(IconMarginProperty, value); }
        }
    }
}
