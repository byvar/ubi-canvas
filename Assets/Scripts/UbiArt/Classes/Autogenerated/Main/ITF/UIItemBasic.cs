using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class UIItemBasic : UIItem {
		[Serialize("selectTextStyle"           )] public uint selectTextStyle;
		[Serialize("selectAnimMeshVertex"      )] public CList<StringID> selectAnimMeshVertex;
		[Serialize("PathForMap"                )] public PathRef PathForMap;
		[Serialize("nextMenuOnValidate"        )] public StringID nextMenuOnValidate;
		[Serialize("WwiseGUID_OnValidate"      )] public StringID WwiseGUID_OnValidate;
		[Serialize("WwiseGUID_OnValidateLocked")] public StringID WwiseGUID_OnValidateLocked;
		[Serialize("WwiseGUID_OnSelect"        )] public StringID WwiseGUID_OnSelect;
		[Serialize("OnValidateEvents"          )] public CList<sEventData> OnValidateEvents;
		[Serialize("OnValidateLockedEvents"    )] public CList<sEventData> OnValidateLockedEvents;
		[Serialize("OnSelectEvents"            )] public CList<sEventData> OnSelectEvents;
		[Serialize("WwiseOnValidate"           )] public EventSender WwiseOnValidate;
		[Serialize("isUIPADListener"           )] public bool isUIPADListener;
		[Serialize("isUIFruityListener"        )] public bool isUIFruityListener;
		[Serialize("isDisplayedWithPad"        )] public bool isDisplayedWithPad;
		[Serialize("isDisplayedWithTouch"      )] public bool isDisplayedWithTouch;
		[Serialize("padPointerOffset"          )] public Vector2 padPointerOffset;

		[Serialize("EventSender__3"            )] public EventSender EventSender__3;
		[Serialize("EventSender__4"            )] public EventSender EventSender__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(selectTextStyle));
				SerializeField(s, nameof(selectAnimMeshVertex));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(selectTextStyle));
				SerializeField(s, nameof(selectAnimMeshVertex));
				SerializeField(s, nameof(PathForMap));
				SerializeField(s, nameof(EventSender__3));
				SerializeField(s, nameof(EventSender__4));
			} else {
				SerializeField(s, nameof(selectTextStyle));
				SerializeField(s, nameof(selectAnimMeshVertex));
				SerializeField(s, nameof(PathForMap));
				if (!s.HasFlags(SerializeFlags.Editor)) {
					SerializeField(s, nameof(nextMenuOnValidate));
				} else {
					SerializeFieldAsChoiceList(s, nameof(nextMenuOnValidate), "Empty");
				}
				SerializeField(s, nameof(WwiseGUID_OnValidate));
				SerializeField(s, nameof(WwiseGUID_OnValidateLocked));
				SerializeField(s, nameof(WwiseGUID_OnSelect));
				SerializeField(s, nameof(OnValidateEvents));
				SerializeField(s, nameof(OnValidateLockedEvents));
				SerializeField(s, nameof(OnSelectEvents));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(WwiseOnValidate));
				}
				SerializeField(s, nameof(isUIPADListener));
				SerializeField(s, nameof(isUIFruityListener));
				SerializeField(s, nameof(isDisplayedWithPad));
				SerializeField(s, nameof(isDisplayedWithTouch));
				SerializeField(s, nameof(padPointerOffset));
			}
		}
		public override uint? ClassCRC => 0xEC59CF6E;
	}
}

