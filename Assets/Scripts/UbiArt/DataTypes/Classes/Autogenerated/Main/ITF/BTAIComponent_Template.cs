namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTAIComponent_Template : EntityComponent_Template {
		public BehaviorTree_Template behaviorTree;
		public bool registerToAIManager;
		public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				behaviorTree = s.SerializeObject<BehaviorTree_Template>(behaviorTree, name: "behaviorTree");
			} else {
				behaviorTree = s.SerializeObject<BehaviorTree_Template>(behaviorTree, name: "behaviorTree");
				registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
				faction = s.Serialize<uint>(faction, name: "faction");
			}
		}
		public override uint? ClassCRC => 0x90EB29DB;
	}
}

