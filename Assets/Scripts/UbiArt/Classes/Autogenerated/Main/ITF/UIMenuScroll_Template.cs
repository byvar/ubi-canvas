using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenuScroll_Template : UIMenuBasic_Template {
		public int modelSperatorIndex;
		public float movingSelectionDelay;
		public float movingSelectionNormMax;
		public float movingBounceTime;
		public float movingBounceNorm;
		public bool movingSnapOnItem;
		public float movingMomentumFriction;
		public float movingMomentumDeceleration;
		public Vec2d extendSpeed;
		public Vec2d colapseSpeed;
		public CArrayO<Path> modelActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				modelActorPaths = s.SerializeObject<CArrayO<Path>>(modelActorPaths, name: "modelActorPaths");
				modelSperatorIndex = s.Serialize<int>(modelSperatorIndex, name: "modelSperatorIndex");
				movingSelectionDelay = s.Serialize<float>(movingSelectionDelay, name: "movingSelectionDelay");
				movingSelectionNormMax = s.Serialize<float>(movingSelectionNormMax, name: "movingSelectionNormMax");
				movingBounceTime = s.Serialize<float>(movingBounceTime, name: "movingBounceTime");
				movingBounceNorm = s.Serialize<float>(movingBounceNorm, name: "movingBounceNorm");
				movingSnapOnItem = s.Serialize<bool>(movingSnapOnItem, name: "movingSnapOnItem");
				movingMomentumFriction = s.Serialize<float>(movingMomentumFriction, name: "movingMomentumFriction");
				movingMomentumDeceleration = s.Serialize<float>(movingMomentumDeceleration, name: "movingMomentumDeceleration");
				extendSpeed = s.SerializeObject<Vec2d>(extendSpeed, name: "extendSpeed");
				colapseSpeed = s.SerializeObject<Vec2d>(colapseSpeed, name: "colapseSpeed");
			} else {
				modelSperatorIndex = s.Serialize<int>(modelSperatorIndex, name: "modelSperatorIndex");
				movingSelectionDelay = s.Serialize<float>(movingSelectionDelay, name: "movingSelectionDelay");
				movingSelectionNormMax = s.Serialize<float>(movingSelectionNormMax, name: "movingSelectionNormMax");
				movingBounceTime = s.Serialize<float>(movingBounceTime, name: "movingBounceTime");
				movingBounceNorm = s.Serialize<float>(movingBounceNorm, name: "movingBounceNorm");
				movingSnapOnItem = s.Serialize<bool>(movingSnapOnItem, name: "movingSnapOnItem");
				movingMomentumFriction = s.Serialize<float>(movingMomentumFriction, name: "movingMomentumFriction");
				movingMomentumDeceleration = s.Serialize<float>(movingMomentumDeceleration, name: "movingMomentumDeceleration");
				extendSpeed = s.SerializeObject<Vec2d>(extendSpeed, name: "extendSpeed");
				colapseSpeed = s.SerializeObject<Vec2d>(colapseSpeed, name: "colapseSpeed");
			}
		}
		public override uint? ClassCRC => 0x38BA4835;
	}
}

