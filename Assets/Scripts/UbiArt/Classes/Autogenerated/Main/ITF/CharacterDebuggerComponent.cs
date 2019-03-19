using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CharacterDebuggerComponent : ActorComponent {
		[Serialize("DebugFlags"          )] public CharacterDebuggerComponent__CharacterDebug DebugFlags;
		[Serialize("trajectoryPointCount")] public uint trajectoryPointCount;
		[Serialize("barFrameCount"       )] public uint barFrameCount;
		[Serialize("beatFrameCount"      )] public uint beatFrameCount;
		[Serialize("barColor"            )] public Color barColor;
		[Serialize("beatColor"           )] public Color beatColor;
		[Serialize("halfBeatColor"       )] public Color halfBeatColor;
		[Serialize("leftButtonColor"     )] public Color leftButtonColor;
		[Serialize("rightButtonColor"    )] public Color rightButtonColor;
		[Serialize("logCurrentAnimation" )] public bool logCurrentAnimation;
		[Serialize("alwaysShowDebug"     )] public bool alwaysShowDebug;
		[Serialize("writeLog"            )] public bool writeLog;
		[Serialize("uint__0"             )] public uint uint__0;
		[Serialize("uint__1"             )] public uint uint__1;
		[Serialize("uint__2"             )] public uint uint__2;
		[Serialize("uint__3"             )] public uint uint__3;
		[Serialize("Color__4"            )] public Color Color__4;
		[Serialize("Color__5"            )] public Color Color__5;
		[Serialize("Color__6"            )] public Color Color__6;
		[Serialize("Color__7"            )] public Color Color__7;
		[Serialize("Color__8"            )] public Color Color__8;
		[Serialize("bool__9"             )] public bool bool__9;
		[Serialize("bool__10"            )] public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(trajectoryPointCount));
				SerializeField(s, nameof(barFrameCount));
				SerializeField(s, nameof(beatFrameCount));
				SerializeField(s, nameof(barColor));
				SerializeField(s, nameof(beatColor));
				SerializeField(s, nameof(halfBeatColor));
				SerializeField(s, nameof(leftButtonColor));
				SerializeField(s, nameof(rightButtonColor));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(uint__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(Color__4));
				SerializeField(s, nameof(Color__5));
				SerializeField(s, nameof(Color__6));
				SerializeField(s, nameof(Color__7));
				SerializeField(s, nameof(Color__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
			} else {
				SerializeField(s, nameof(DebugFlags));
				SerializeField(s, nameof(trajectoryPointCount));
				SerializeField(s, nameof(barFrameCount));
				SerializeField(s, nameof(beatFrameCount));
				SerializeField(s, nameof(barColor));
				SerializeField(s, nameof(beatColor));
				SerializeField(s, nameof(halfBeatColor));
				SerializeField(s, nameof(leftButtonColor));
				SerializeField(s, nameof(rightButtonColor));
				SerializeField(s, nameof(logCurrentAnimation));
				SerializeField(s, nameof(alwaysShowDebug));
				SerializeField(s, nameof(writeLog));
			}
		}
		public enum CharacterDebuggerComponent__CharacterDebug {
			[Serialize("CharacterDebuggerComponent::CharacterDebug_Collider"   )] Collider = 1,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_Trajectory" )] Trajectory = 2,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_Controller" )] Controller = 4,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_Anim"       )] Anim = 8,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_AnimInputs" )] AnimInputs = 16,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_AI"         )] AI = 32,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_SoundInputs")] SoundInputs = 64,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_ActorPos"   )] ActorPos = 128,
			[Serialize("CharacterDebuggerComponent::CharacterDebug_States"     )] States = 256,
		}
		public override uint? ClassCRC => 0xDD1CC543;
	}
}

