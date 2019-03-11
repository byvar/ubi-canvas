using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextAnimScaleComponent : ActorComponent {
		[Serialize("isActive"                 )] public bool isActive;
		[Serialize("margingTop"               )] public float margingTop;
		[Serialize("margingLeft"              )] public float margingLeft;
		[Serialize("margingRight"             )] public float margingRight;
		[Serialize("margingBottom"            )] public float margingBottom;
		[Serialize("scaleType"                )] public ScaleType scaleType;
		[Serialize("autoFillContained"        )] public bool autoFillContained;
		[Serialize("ContainedChildren"        )] public CList<ObjectPath> ContainedChildren;
		[Serialize("autoFillReposition"       )] public bool autoFillReposition;
		[Serialize("repositionObjects"        )] public CList<ObjectPath> repositionObjects;
		[Serialize("relRepositionObjects"     )] public CList<ObjectPath> relRepositionObjects;
		[Serialize("borderRepositionedObjects")] public CList<AnimScaleRepositionedObject> borderRepositionedObjects;
		[Serialize("minimumSize"              )] public Vector2 minimumSize;
		[Serialize("aabb"                     )] public AABB aabb;
		[Serialize("scaleType"                )] public Enum_scaleType scaleType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(isActive));
					SerializeField(s, nameof(margingTop));
					SerializeField(s, nameof(margingLeft));
					SerializeField(s, nameof(margingRight));
					SerializeField(s, nameof(margingBottom));
					SerializeField(s, nameof(scaleType));
					SerializeField(s, nameof(autoFillContained));
					SerializeField(s, nameof(ContainedChildren));
					SerializeField(s, nameof(autoFillReposition));
					SerializeField(s, nameof(repositionObjects));
					SerializeField(s, nameof(relRepositionObjects));
					SerializeField(s, nameof(minimumSize));
					SerializeField(s, nameof(aabb));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(isActive));
					SerializeField(s, nameof(margingTop));
					SerializeField(s, nameof(margingLeft));
					SerializeField(s, nameof(margingRight));
					SerializeField(s, nameof(margingBottom));
					SerializeField(s, nameof(scaleType));
					SerializeField(s, nameof(autoFillContained));
					SerializeField(s, nameof(ContainedChildren));
					SerializeField(s, nameof(autoFillReposition));
					SerializeField(s, nameof(repositionObjects));
					SerializeField(s, nameof(relRepositionObjects));
					SerializeField(s, nameof(borderRepositionedObjects));
					SerializeField(s, nameof(minimumSize));
					SerializeField(s, nameof(aabb));
				}
			}
		}
		public enum ScaleType {
			[Serialize("ScaleType_None"       )] None = 0,
			[Serialize("ScaleType_Horizontale")] Horizontale = 1,
			[Serialize("ScaleType_Verticale"  )] Verticale = 2,
			[Serialize("ScaleType_All"        )] All = 3,
		}
		public enum Enum_scaleType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xA9A85954;
	}
}

