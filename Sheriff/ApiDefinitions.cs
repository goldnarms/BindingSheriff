using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Sheriff
{
	// @interface GIBadgeView : UIView
	[BaseType (typeof(UIView))]
	interface GIBadgeView
	{
		// @property (nonatomic) NSInteger badgeValue;
		[Export ("badgeValue")]
		nint BadgeValue { get; set; }

		// @property (nonatomic, strong) UIColor * textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIFont * font;
		[Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic) CGFloat topOffset;
		[Export ("topOffset")]
		nfloat TopOffset { get; set; }

		// @property (nonatomic) CGFloat rightOffset;
		[Export ("rightOffset")]
		nfloat RightOffset { get; set; }

		// -(void)increment;
		[Export ("increment")]
		void Increment ();

		// -(void)decrement;
		[Export ("decrement")]
		void Decrement ();
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double SheriffVersionNumber;
		[Field ("SheriffVersionNumber", "__Internal")]
		double SheriffVersionNumber { get; }

		// extern const unsigned char [] SheriffVersionString;
		[Field ("SheriffVersionString", "__Internal")]
		byte[] SheriffVersionString { get; }
	}
}
