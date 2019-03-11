using UnityEngine;

namespace UbiArt.ITF {
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
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(slideBarWidth));
				SerializeField(s, nameof(fixPosX));
				SerializeField(s, nameof(fixPosY));
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

