using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CharacterDebuggerComponent : ActorComponent {
		public CharacterDebug DebugFlags;
		public uint trajectoryPointCount;
		public uint barFrameCount;
		public uint beatFrameCount;
		public Color barColor;
		public Color beatColor;
		public Color halfBeatColor;
		public Color leftButtonColor;
		public Color rightButtonColor;
		public bool logCurrentAnimation;
		public bool alwaysShowDebug;
		public bool writeLog;
		public uint uint__0;
		public uint uint__1;
		public uint uint__2;
		public uint uint__3;
		public bool bool__9;
		public bool bool__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				trajectoryPointCount = s.Serialize<uint>(trajectoryPointCount, name: "trajectoryPointCount");
				barFrameCount = s.Serialize<uint>(barFrameCount, name: "barFrameCount");
				beatFrameCount = s.Serialize<uint>(beatFrameCount, name: "beatFrameCount");
				barColor = s.SerializeObject<Color>(barColor, name: "barColor");
				beatColor = s.SerializeObject<Color>(beatColor, name: "beatColor");
				halfBeatColor = s.SerializeObject<Color>(halfBeatColor, name: "halfBeatColor");
				leftButtonColor = s.SerializeObject<Color>(leftButtonColor, name: "leftButtonColor");
				rightButtonColor = s.SerializeObject<Color>(rightButtonColor, name: "rightButtonColor");
			} else if (Settings.s.game == Settings.Game.VH) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
				uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
				uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				barColor = s.SerializeObject<Color>(barColor, name: "barColor");
				beatColor = s.SerializeObject<Color>(beatColor, name: "beatColor");
				halfBeatColor = s.SerializeObject<Color>(halfBeatColor, name: "halfBeatColor");
				leftButtonColor = s.SerializeObject<Color>(leftButtonColor, name: "leftButtonColor");
				rightButtonColor = s.SerializeObject<Color>(rightButtonColor, name: "rightButtonColor");
				bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
			} else {
				DebugFlags = s.Serialize<CharacterDebug>(DebugFlags, name: "DebugFlags");
				trajectoryPointCount = s.Serialize<uint>(trajectoryPointCount, name: "trajectoryPointCount");
				barFrameCount = s.Serialize<uint>(barFrameCount, name: "barFrameCount");
				beatFrameCount = s.Serialize<uint>(beatFrameCount, name: "beatFrameCount");
				barColor = s.SerializeObject<Color>(barColor, name: "barColor");
				beatColor = s.SerializeObject<Color>(beatColor, name: "beatColor");
				halfBeatColor = s.SerializeObject<Color>(halfBeatColor, name: "halfBeatColor");
				leftButtonColor = s.SerializeObject<Color>(leftButtonColor, name: "leftButtonColor");
				rightButtonColor = s.SerializeObject<Color>(rightButtonColor, name: "rightButtonColor");
				logCurrentAnimation = s.Serialize<bool>(logCurrentAnimation, name: "logCurrentAnimation");
				alwaysShowDebug = s.Serialize<bool>(alwaysShowDebug, name: "alwaysShowDebug");
				writeLog = s.Serialize<bool>(writeLog, name: "writeLog");
			}
		}
		[Flags]
		public enum CharacterDebug {
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

