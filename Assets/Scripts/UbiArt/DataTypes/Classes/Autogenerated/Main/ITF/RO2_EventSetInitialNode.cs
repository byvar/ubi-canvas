namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventSetInitialNode : Event {
		public bool getNodeFromSender;
		public bool interruptCurrentNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			getNodeFromSender = s.Serialize<bool>(getNodeFromSender, name: "getNodeFromSender");
			interruptCurrentNode = s.Serialize<bool>(interruptCurrentNode, name: "interruptCurrentNode");
		}
		public override uint? ClassCRC => 0xCF4913AC;
	}
}

