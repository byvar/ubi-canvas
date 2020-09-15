using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenuScroll_Template : UIMenuBasic_Template {
		[Serialize("modelSperatorIndex"        )] public int modelSperatorIndex;
		[Serialize("movingSelectionDelay"      )] public float movingSelectionDelay;
		[Serialize("movingSelectionNormMax"    )] public float movingSelectionNormMax;
		[Serialize("movingBounceTime"          )] public float movingBounceTime;
		[Serialize("movingBounceNorm"          )] public float movingBounceNorm;
		[Serialize("movingSnapOnItem"          )] public bool movingSnapOnItem;
		[Serialize("movingMomentumFriction"    )] public float movingMomentumFriction;
		[Serialize("movingMomentumDeceleration")] public float movingMomentumDeceleration;
		[Serialize("extendSpeed"               )] public Vec2d extendSpeed;
		[Serialize("colapseSpeed"              )] public Vec2d colapseSpeed;
		[Serialize("modelActorPaths"           )] public CArray<Path> modelActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(modelActorPaths));
				SerializeField(s, nameof(modelSperatorIndex));
				SerializeField(s, nameof(movingSelectionDelay));
				SerializeField(s, nameof(movingSelectionNormMax));
				SerializeField(s, nameof(movingBounceTime));
				SerializeField(s, nameof(movingBounceNorm));
				SerializeField(s, nameof(movingSnapOnItem));
				SerializeField(s, nameof(movingMomentumFriction));
				SerializeField(s, nameof(movingMomentumDeceleration));
				SerializeField(s, nameof(extendSpeed));
				SerializeField(s, nameof(colapseSpeed));
			} else {
				SerializeField(s, nameof(modelSperatorIndex));
				SerializeField(s, nameof(movingSelectionDelay));
				SerializeField(s, nameof(movingSelectionNormMax));
				SerializeField(s, nameof(movingBounceTime));
				SerializeField(s, nameof(movingBounceNorm));
				SerializeField(s, nameof(movingSnapOnItem));
				SerializeField(s, nameof(movingMomentumFriction));
				SerializeField(s, nameof(movingMomentumDeceleration));
				SerializeField(s, nameof(extendSpeed));
				SerializeField(s, nameof(colapseSpeed));
			}
		}
		public override uint? ClassCRC => 0x38BA4835;
	}
}

