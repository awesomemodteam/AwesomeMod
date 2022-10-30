using UnityEngine;
using VRC;
using BE4v.Mods.Core;

namespace BE4v.Mods.Min
{
    public class MouseTP : IUpdate
    {
        public void Update()
        {
            if (!Threads.isCtrl) return;
            if (Input.GetKeyDown(KeyCode.Mouse2))
            {
                Player player = Player.Instance;
                if (player == null) return;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
                    player.transform.position = hit.point;
            }
        }
    }
}
