﻿namespace Gu.Wpf.UiAutomation.UIA3.Patterns
{
    using Gu.Wpf.UiAutomation.UIA3.Identifiers;
    using UIA = Interop.UIAutomationClient;

    public class ScrollPattern : ScrollPatternBase<UIA.IUIAutomationScrollPattern>
    {
        public static readonly PatternId Pattern = PatternId.Register(UIA.UIA_PatternIds.UIA_ScrollPatternId, "Scroll", AutomationObjectIds.IsScrollPatternAvailableProperty);
        public static readonly PropertyId HorizontallyScrollableProperty = PropertyId.Register(UIA.UIA_PropertyIds.UIA_ScrollHorizontallyScrollablePropertyId, "HorizontallyScrollable");
        public static readonly PropertyId HorizontalScrollPercentProperty = PropertyId.Register(UIA.UIA_PropertyIds.UIA_ScrollHorizontalScrollPercentPropertyId, "HorizontalScrollPercent");
        public static readonly PropertyId HorizontalViewSizeProperty = PropertyId.Register(UIA.UIA_PropertyIds.UIA_ScrollHorizontalViewSizePropertyId, "HorizontalViewSize");
        public static readonly PropertyId VerticallyScrollableProperty = PropertyId.Register(UIA.UIA_PropertyIds.UIA_ScrollVerticallyScrollablePropertyId, "VerticallyScrollable");
        public static readonly PropertyId VerticalScrollPercentProperty = PropertyId.Register(UIA.UIA_PropertyIds.UIA_ScrollVerticalScrollPercentPropertyId, "VerticalScrollPercent");
        public static readonly PropertyId VerticalViewSizeProperty = PropertyId.Register(UIA.UIA_PropertyIds.UIA_ScrollVerticalViewSizePropertyId, "VerticalViewSize");

        public ScrollPattern(BasicAutomationElementBase basicAutomationElement, UIA.IUIAutomationScrollPattern nativePattern)
            : base(basicAutomationElement, nativePattern)
        {
        }

        public override void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount)
        {
            ComCallWrapper.Call(() => this.NativePattern.Scroll((UIA.ScrollAmount)horizontalAmount, (UIA.ScrollAmount)verticalAmount));
        }

        public override void SetScrollPercent(double horizontalPercent, double verticalPercent)
        {
            ComCallWrapper.Call(() => this.NativePattern.SetScrollPercent(horizontalPercent, verticalPercent));
        }
    }
}