using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTestComponent : ActorComponent {
		public bool AutoStart;
		public CListO<Generic<TriggerSelectionAbstract>> Detection;
		public Operator DetectionOperator;
		public CListO<Generic<TriggerTestAbstract>> Test;
		public Operator TestOperator;
		public Enum_PlayMode PlayMode;
		public CListO<sEventData> OnActivate;
		public CListO<sEventData> OnDeactivate;
		public CListO<sEventData> OnStayActive;
		public float StayActiveDelay;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				AutoStart = s.Serialize<bool>(AutoStart, name: "AutoStart");
				if (!s.HasFlags(SerializeFlags.Editor)) {
					Detection = s.SerializeObject<CListO<Generic<TriggerSelectionAbstract>>>(Detection, name: "Detection");
					DetectionOperator = s.Serialize<Operator>(DetectionOperator, name: "DetectionOperator");
					Test = s.SerializeObject<CListO<Generic<TriggerTestAbstract>>>(Test, name: "Test");
					TestOperator = s.Serialize<Operator>(TestOperator, name: "TestOperator");
				} else if (!AutoStart) {
					Detection = s.SerializeObject<CListO<Generic<TriggerSelectionAbstract>>>(Detection, name: "Detection");
					if (Detection.Count > 1) DetectionOperator = s.Serialize<Operator>(DetectionOperator, name: "DetectionOperator");
					Test = s.SerializeObject<CListO<Generic<TriggerTestAbstract>>>(Test, name: "Test");
					if (Test.Count > 1) TestOperator = s.Serialize<Operator>(TestOperator, name: "TestOperator");
				}
				OnActivate = s.SerializeObject<CListO<sEventData>>(OnActivate, name: "OnActivate");
				OnDeactivate = s.SerializeObject<CListO<sEventData>>(OnDeactivate, name: "OnDeactivate");
				OnStayActive = s.SerializeObject<CListO<sEventData>>(OnStayActive, name: "OnStayActive");
			} else {
				AutoStart = s.Serialize<bool>(AutoStart, name: "AutoStart");
				if (!s.HasFlags(SerializeFlags.Editor)) {
					Detection = s.SerializeObject<CListO<Generic<TriggerSelectionAbstract>>>(Detection, name: "Detection");
					DetectionOperator = s.Serialize<Operator>(DetectionOperator, name: "DetectionOperator");
					Test = s.SerializeObject<CListO<Generic<TriggerTestAbstract>>>(Test, name: "Test");
					TestOperator = s.Serialize<Operator>(TestOperator, name: "TestOperator");
					PlayMode = s.Serialize<Enum_PlayMode>(PlayMode, name: "PlayMode");
				} else if(!AutoStart) {
					Detection = s.SerializeObject<CListO<Generic<TriggerSelectionAbstract>>>(Detection, name: "Detection");
					if (Detection.Count > 1) DetectionOperator = s.Serialize<Operator>(DetectionOperator, name: "DetectionOperator");
					Test = s.SerializeObject<CListO<Generic<TriggerTestAbstract>>>(Test, name: "Test");
					if (Test.Count > 1) TestOperator = s.Serialize<Operator>(TestOperator, name: "TestOperator");
				}
				OnActivate = s.SerializeObject<CListO<sEventData>>(OnActivate, name: "OnActivate");
				OnDeactivate = s.SerializeObject<CListO<sEventData>>(OnDeactivate, name: "OnDeactivate");
				OnStayActive = s.SerializeObject<CListO<sEventData>>(OnStayActive, name: "OnStayActive");
				if (s.HasFlags(SerializeFlags.Editor)) {
					StayActiveDelay = s.Serialize<float>(StayActiveDelay, name: "StayActiveDelay");
				}
			}
		}
		public enum Operator {
			[Serialize("AND")] AND = 0,
			[Serialize("OR" )] OR = 1,
		}
		public enum Enum_PlayMode {
			[Serialize("LOOP")] LOOP = 0,
			[Serialize("ONCE")] ONCE = 1,
		}
		public override uint? ClassCRC => 0xC3ACA835;
	}
}

