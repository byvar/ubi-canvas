using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Pickable : BaseObject {
		protected GameObject gao;
		public GameObject Gao {
			get {
				if (gao == null) {
					InitGameObject();
				}
				return gao;
			}
		}

		protected virtual void InitGameObject() {
			gao = new GameObject(userFriendly);
			gao.transform.localPosition = new Vector3(pos2D.x, pos2D.y, -relativeZ);
			gao.transform.localScale = new Vector3(scale.x, scale.y, 1f);
		}

		[Serialize(0, "RELATIVEZ")] public float relativeZ;
		[Serialize(1, "SCALE")] public Vector2 scale = Vector2.one;
		[Serialize(2, "xFLIPPED")] public bool xFlipped;
		[Serialize(3, "USERFRIENDLY")] public string userFriendly;
		[Serialize(4, "UPDATEDEPENDENCYLIST")] public uint updateDependencyList;
		[Serialize(5, "POS2D")] public Vector2 pos2D;
		[Serialize(6, "ANGLE")] public Angle angle;
		[Serialize(7, "INSTANCEDATAFILE")] public Path instanceDataFile;


		public Pickable(Reader reader) : base(reader) {
		}
		public bool CheckFlags(uint flags) {
			return true; // todo
		}
	}
}
