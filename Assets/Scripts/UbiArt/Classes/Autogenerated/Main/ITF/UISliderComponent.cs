using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class UISliderComponent : UIItemBasic {
		[Serialize("itemCursorID"            )] public StringID itemCursorID;
		[Serialize("itemBarID"               )] public StringID itemBarID;
		[Serialize("slideBarAbsoluteWidth"   )] public float slideBarAbsoluteWidth;
		[Serialize("slideBarWidth"           )] public float slideBarWidth;
		[Serialize("fixPosX"                 )] public float fixPosX;
		[Serialize("fixPosY"                 )] public float fixPosY;
		[Serialize("maxValue"                )] public float maxValue;
		[Serialize("cursorSpeed"             )] public float cursorSpeed;
		[Serialize("useSliderOrigin"         )] public bool useSliderOrigin;
		[Serialize("verticalNotHorizontal"   )] public bool verticalNotHorizontal;
		[Serialize("needPressValidateToSlide")] public bool needPressValidateToSlide;
		[Serialize("enableValueText"         )] public bool enableValueText;
		[Serialize("StringID__0"             )] public StringID StringID__0;
		[Serialize("StringID__1"             )] public StringID StringID__1;
		[Serialize("float__2"                )] public float float__2;
		[Serialize("float__3"                )] public float float__3;
		[Serialize("float__4"                )] public float float__4;
		[Serialize("float__5"                )] public float float__5;
		[Serialize("float__6"                )] public float float__6;
		[Serialize("bool__7"                 )] public bool bool__7;
		[Serialize("bool__8"                 )] public bool bool__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(slideBarWidth));
				SerializeField(s, nameof(fixPosX));
				SerializeField(s, nameof(fixPosY));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
			} else {
				SerializeField(s, nameof(itemCursorID));
				SerializeField(s, nameof(itemBarID));
				SerializeField(s, nameof(slideBarAbsoluteWidth));
				SerializeField(s, nameof(slideBarWidth));
				SerializeField(s, nameof(fixPosX));
				SerializeField(s, nameof(fixPosY));
				SerializeField(s, nameof(maxValue));
				SerializeField(s, nameof(cursorSpeed));
				SerializeField(s, nameof(useSliderOrigin));
				SerializeField(s, nameof(verticalNotHorizontal));
				SerializeField(s, nameof(needPressValidateToSlide));
				SerializeField(s, nameof(enableValueText));
			}
		}
		public override uint? ClassCRC => 0x0E148AF2;
	}
}

