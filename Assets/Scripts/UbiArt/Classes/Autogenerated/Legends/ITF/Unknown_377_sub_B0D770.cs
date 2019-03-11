using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_377_sub_B0D770 : CSerializable {
		[Serialize("idleBehavior"       )] public Placeholder idleBehavior;
		[Serialize("attackBehavior"     )] public Placeholder attackBehavior;
		[Serialize("receiveHitBehavior" )] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"      )] public Placeholder deathBehavior;
		[Serialize("crushedBehavior"    )] public Placeholder crushedBehavior;
		[Serialize("activateBehavior"   )] public Placeholder activateBehavior;
		[Serialize("desactivateBehavior")] public Placeholder desactivateBehavior;
		[Serialize("closedBehavior"     )] public Placeholder closedBehavior;
		[Serialize("tickleBehavior"     )] public Placeholder tickleBehavior;
		[Serialize("findEnemyRadius"    )] public float findEnemyRadius;
		[Serialize("closeRadius"        )] public float closeRadius;
		[Serialize("useRadius"          )] public bool useRadius;
		[Serialize("detectionRange"     )] public Placeholder detectionRange;
		[Serialize("detectionCloseRange")] public Placeholder detectionCloseRange;
		[Serialize("triggerable"        )] public bool triggerable;
		[Serialize("forceLookDir"       )] public bool forceLookDir;
		[Serialize("forceLookDirRight"  )] public bool forceLookDirRight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleBehavior));
			SerializeField(s, nameof(attackBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(crushedBehavior));
			SerializeField(s, nameof(activateBehavior));
			SerializeField(s, nameof(desactivateBehavior));
			SerializeField(s, nameof(closedBehavior));
			SerializeField(s, nameof(tickleBehavior));
			SerializeField(s, nameof(findEnemyRadius));
			SerializeField(s, nameof(closeRadius));
			SerializeField(s, nameof(useRadius));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(detectionCloseRange));
			SerializeField(s, nameof(triggerable));
			SerializeField(s, nameof(forceLookDir));
			SerializeField(s, nameof(forceLookDirRight));
		}
		public override uint? ClassCRC => 0x90FB42C0;
	}
}

