using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SubAnim_Template : BaseObject {
		[Serialize(0, "friendlyName")] public StringID friendlyName;
		[Serialize(1, "name")] public Path name;
		[Serialize(2, "playRate")] public float playRate;
		[Serialize(3, "loop")] public bool loop;
		[Serialize(4, "flags", game = Settings.Game.RA)] public uint flags;
		[Serialize(5, "useRootRotation")] public bool useRootRotation;
		[Serialize(6, "reverse")] public bool reverse;
		[Serialize(7, "defaultFlip")] public bool defaultFlip;
		[Serialize(8, "markerStart")] public StringID markerStart;
		[Serialize(9, "markerStop")] public StringID markerStop;
		[Serialize(10, "procedural")] public bool procedural;
		[Serialize(11, "sync")] public bool sync;
		[Serialize(12, "syncEighthNote")] public uint syncEighthNote;
		[Serialize(13, "syncRatio")] public float syncRatio;
		[Serialize(14, "allowSyncOffset")] public bool allowSyncOffset;
		[Serialize(15, "shadowMul")] public float shadowMul;
		[Serialize(16, "metronome")] public MetronomeType metronome;
		[Serialize(17, "forceZOffset", game = Settings.Game.RL)] public ForceZOffset forceZOffset;
		[Serialize(17, "forceZOffset", game = Settings.Game.RA)] public bool forceZOffsetBool;
		[Serialize(18, "useRootFlip", game = Settings.Game.RA)] public bool useRootFlip;

		public SubAnim_Template(Reader reader) : base(reader) {
		}

		public enum MetronomeType {
			Default = 0,
			Menu,
			Gameplay,
			Invalid = 4 // Adventures only.
		}

		public enum ForceZOffset {
			False = 0,
			True,
			Other // Legends only. In Adventures it's just a bool
		}
	}
}
