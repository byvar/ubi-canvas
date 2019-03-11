using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorPlugComponent_Template : ActorComponent_Template {
		[Serialize("controllers"            )] public CArray<Generic<ActorPlugBaseController_Template>> controllers;
		[Serialize("unpluggedControllerID"  )] public StringID unpluggedControllerID;
		[Serialize("stateMachine"           )] public WithAnimStateMachine_Template stateMachine;
		[Serialize("plugInterfaceParameters")] public ActorPlugInterface_Parameters plugInterfaceParameters;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(controllers));
			SerializeField(s, nameof(unpluggedControllerID));
			SerializeField(s, nameof(stateMachine));
			SerializeField(s, nameof(plugInterfaceParameters));
		}
		public override uint? ClassCRC => 0x7F21C44B;
	}
}

