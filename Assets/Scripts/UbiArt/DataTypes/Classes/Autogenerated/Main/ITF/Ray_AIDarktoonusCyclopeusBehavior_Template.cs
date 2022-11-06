using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonusCyclopeusBehavior_Template : TemplateAIBehavior {
		public Placeholder idle;
		public Placeholder prepareFocus;
		public Placeholder focus;
		public Placeholder attack;
		public Placeholder waitHit;
		public float distanceDetect;
		public Angle angleMaxDetect;
		public float countDownAttack;
		public float speed;
		public float speedBack;
		public float timeWaiting;
		public float timeFocus;
		public int mustBeStickToAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			prepareFocus = s.SerializeObject<Placeholder>(prepareFocus, name: "prepareFocus");
			focus = s.SerializeObject<Placeholder>(focus, name: "focus");
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
			waitHit = s.SerializeObject<Placeholder>(waitHit, name: "waitHit");
			distanceDetect = s.Serialize<float>(distanceDetect, name: "distanceDetect");
			angleMaxDetect = s.SerializeObject<Angle>(angleMaxDetect, name: "angleMaxDetect");
			countDownAttack = s.Serialize<float>(countDownAttack, name: "countDownAttack");
			speed = s.Serialize<float>(speed, name: "speed");
			speedBack = s.Serialize<float>(speedBack, name: "speedBack");
			timeWaiting = s.Serialize<float>(timeWaiting, name: "timeWaiting");
			timeFocus = s.Serialize<float>(timeFocus, name: "timeFocus");
			mustBeStickToAttack = s.Serialize<int>(mustBeStickToAttack, name: "mustBeStickToAttack");
		}
		public override uint? ClassCRC => 0x24D2B959;
	}
}

