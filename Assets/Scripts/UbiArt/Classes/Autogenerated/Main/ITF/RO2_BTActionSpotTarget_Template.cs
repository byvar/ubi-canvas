using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionSpotTarget_Template : BTAction_Template {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("animSpot"           )] public StringID animSpot;
		[Serialize("animFight"          )] public StringID animFight;
		[Serialize("animUTurn"          )] public StringID animUTurn;
		[Serialize("timingStaySpotting" )] public float timingStaySpotting;
		[Serialize("disableUTurn"       )] public bool disableUTurn;
		[Serialize("debug"              )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(animSpot));
			SerializeField(s, nameof(animFight));
			SerializeField(s, nameof(animUTurn));
			SerializeField(s, nameof(timingStaySpotting));
			SerializeField(s, nameof(disableUTurn));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0x0BF8D095;
	}
}

