using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class CameraModifierComponent : ActorComponent {
		[Serialize(0, "cameraView")] public uint cameraView;
		[Serialize(1, "ignoreAABB")] public bool ignoreAABB;
		[Serialize(2, "ignoreSceneActiveState", game = Settings.Game.RA)] public bool ignoreSceneActiveState; // RA
		[Serialize(3, "CM")] public CamModifier cm;
		[Serialize(4, "localAABB")] public AABB localAABB;

		public CameraModifierComponent(Reader reader) : base(reader) {
		}
	}
}
