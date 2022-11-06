using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TextAnimScaleComponent : ActorComponent {
		public bool isActive;
		public float margingTop;
		public float margingLeft;
		public float margingRight;
		public float margingBottom;
		public ScaleType scaleType;
		public bool autoFillContained;
		public CListO<ObjectPath> ContainedChildren;
		public bool autoFillReposition;
		public CListO<ObjectPath> repositionObjects;
		public CListO<ObjectPath> relRepositionObjects;
		public CListO<AnimScaleRepositionedObject> borderRepositionedObjects;
		public Vec2d minimumSize;
		public AABB aabb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					isActive = s.Serialize<bool>(isActive, name: "isActive");
					margingTop = s.Serialize<float>(margingTop, name: "margingTop");
					margingLeft = s.Serialize<float>(margingLeft, name: "margingLeft");
					margingRight = s.Serialize<float>(margingRight, name: "margingRight");
					margingBottom = s.Serialize<float>(margingBottom, name: "margingBottom");
					scaleType = s.Serialize<ScaleType>(scaleType, name: "scaleType");
					autoFillContained = s.Serialize<bool>(autoFillContained, name: "autoFillContained", options: CSerializerObject.Options.BoolAsByte);
					ContainedChildren = s.SerializeObject<CListO<ObjectPath>>(ContainedChildren, name: "ContainedChildren");
					autoFillReposition = s.Serialize<bool>(autoFillReposition, name: "autoFillReposition", options: CSerializerObject.Options.BoolAsByte);
					repositionObjects = s.SerializeObject<CListO<ObjectPath>>(repositionObjects, name: "repositionObjects");
					relRepositionObjects = s.SerializeObject<CListO<ObjectPath>>(relRepositionObjects, name: "relRepositionObjects");
					minimumSize = s.SerializeObject<Vec2d>(minimumSize, name: "minimumSize");
					aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					isActive = s.Serialize<bool>(isActive, name: "isActive");
					margingTop = s.Serialize<float>(margingTop, name: "margingTop");
					margingLeft = s.Serialize<float>(margingLeft, name: "margingLeft");
					margingRight = s.Serialize<float>(margingRight, name: "margingRight");
					margingBottom = s.Serialize<float>(margingBottom, name: "margingBottom");
					scaleType = s.Serialize<ScaleType>(scaleType, name: "scaleType");
					autoFillContained = s.Serialize<bool>(autoFillContained, name: "autoFillContained", options: CSerializerObject.Options.BoolAsByte);
					ContainedChildren = s.SerializeObject<CListO<ObjectPath>>(ContainedChildren, name: "ContainedChildren");
					autoFillReposition = s.Serialize<bool>(autoFillReposition, name: "autoFillReposition", options: CSerializerObject.Options.BoolAsByte);
					repositionObjects = s.SerializeObject<CListO<ObjectPath>>(repositionObjects, name: "repositionObjects");
					relRepositionObjects = s.SerializeObject<CListO<ObjectPath>>(relRepositionObjects, name: "relRepositionObjects");
					minimumSize = s.SerializeObject<Vec2d>(minimumSize, name: "minimumSize");
					aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					isActive = s.Serialize<bool>(isActive, name: "isActive");
					margingTop = s.Serialize<float>(margingTop, name: "margingTop");
					margingLeft = s.Serialize<float>(margingLeft, name: "margingLeft");
					margingRight = s.Serialize<float>(margingRight, name: "margingRight");
					margingBottom = s.Serialize<float>(margingBottom, name: "margingBottom");
					scaleType = s.Serialize<ScaleType>(scaleType, name: "scaleType");
					autoFillContained = s.Serialize<bool>(autoFillContained, name: "autoFillContained");
					ContainedChildren = s.SerializeObject<CListO<ObjectPath>>(ContainedChildren, name: "ContainedChildren");
					autoFillReposition = s.Serialize<bool>(autoFillReposition, name: "autoFillReposition");
					repositionObjects = s.SerializeObject<CListO<ObjectPath>>(repositionObjects, name: "repositionObjects");
					relRepositionObjects = s.SerializeObject<CListO<ObjectPath>>(relRepositionObjects, name: "relRepositionObjects");
					borderRepositionedObjects = s.SerializeObject<CListO<AnimScaleRepositionedObject>>(borderRepositionedObjects, name: "borderRepositionedObjects");
					minimumSize = s.SerializeObject<Vec2d>(minimumSize, name: "minimumSize");
					aabb = s.SerializeObject<AABB>(aabb, name: "aabb");
				}
			}
		}
		public enum ScaleType {
			[Serialize("ScaleType_None"       )] None = 0,
			[Serialize("ScaleType_Horizontale")] Horizontale = 1,
			[Serialize("ScaleType_Verticale"  )] Verticale = 2,
			[Serialize("ScaleType_All"        )] All = 3,
		}
		public override uint? ClassCRC => 0xA9A85954;
	}
}

