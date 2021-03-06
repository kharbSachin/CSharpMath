namespace CSharpMath.Rendering.Tests {
  [Android.Runtime.Preserve(AllMembers = true), Foundation.Preserve(AllMembers = true)]
  public sealed class TextData : SharedData<TextData> {
    public const string Accent = @"\'a";
    public const string KindergartenQuestion = @"Mary has \$10. Now she has \$20. How much did she earn?";
    public const string IntegrationByParts = @"
        If $u = u(x)$ and \(du = u'(x)\:dx\), while \(v=v(x)\) and
        $dv = v'(x)\:dx$, then integration by parts states that:$$
        \begin{array}{rcl}
            \int^b_au(x)v'(x)\:dx &=& \left[ u(x)v(x) \right]^b_a - \int^b_a u'(x)v(x)\:dx \\
                                  &=& u(b)v(b) - u(a)v(a) - \int^b_a u'(x)v(x)\:dx
        \end{array} $$ or more compactly: \[\int u\:dv = uv - \int v \:du.\]";
    public const string WideDisplayMaths = @"Text 1$$\sum\int^3_2x\ dx$$Text 2";
    public const string FontStyles = @"\textnormal F\textrm F\textbf F\textcal F\texttt F\textit F\textsf F\textfrak F\textbb F\textbfit F";
  }
}
