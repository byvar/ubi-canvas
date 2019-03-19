using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_AIGroundBaseMovementBehavior_Template : TemplateAIBehavior {
		[Serialize("Generic<AIIdleAction_Template>__0"         )] public Generic<AIIdleAction_Template> Generic_AIIdleAction_Template__0;
		[Serialize("Generic<AIWalkInDirAction_Template>__1"    )] public Generic<AIWalkInDirAction_Template> Generic_AIWalkInDirAction_Template__1;
		[Serialize("Generic<AIUTurnAction_Template>__2"        )] public Generic<AIUTurnAction_Template> Generic_AIUTurnAction_Template__2;
		[Serialize("Generic<AIBounceToLayerAction_Template>__3")] public Generic<AIBounceToLayerAction_Template> Generic_AIBounceToLayerAction_Template__3;
		[Serialize("Generic<AIBumperAction_Template>__4"       )] public Generic<AIBumperAction_Template> Generic_AIBumperAction_Template__4;
		[Serialize("float__5"                                  )] public float float__5;
		[Serialize("float__6"                                  )] public float float__6;
		[Serialize("float__7"                                  )] public float float__7;
		[Serialize("float__8"                                  )] public float float__8;
		[Serialize("float__9"                                  )] public float float__9;
		[Serialize("float__10"                                 )] public float float__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Generic_AIIdleAction_Template__0));
			SerializeField(s, nameof(Generic_AIWalkInDirAction_Template__1));
			SerializeField(s, nameof(Generic_AIUTurnAction_Template__2));
			SerializeField(s, nameof(Generic_AIBounceToLayerAction_Template__3));
			SerializeField(s, nameof(Generic_AIBumperAction_Template__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(float__6));
			SerializeField(s, nameof(float__7));
			SerializeField(s, nameof(float__8));
			SerializeField(s, nameof(float__9));
			SerializeField(s, nameof(float__10));
		}
		public override uint? ClassCRC => 0x3A4B6276;
	}
}

