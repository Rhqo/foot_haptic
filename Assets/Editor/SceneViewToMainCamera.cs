using UnityEditor;
using UnityEngine;

public class SceneViewToMainCamera : EditorWindow
{
    [MenuItem("Tools/Sync Scene View to Main Camera")]
    public static void SyncSceneViewToMainCamera()
    {
        // 씬 뷰를 가져옵니다.
        SceneView sceneView = SceneView.lastActiveSceneView;
        if (sceneView != null && sceneView.camera != null)
        {
            // 씬 뷰 카메라의 위치와 회전을 가져옵니다.
            Camera sceneCamera = sceneView.camera;

            // 메인 카메라를 찾아서 위치와 회전을 설정합니다.
            Camera mainCamera = Camera.main;
            if (mainCamera != null)
            {
                Undo.RecordObject(mainCamera.transform, "Sync Scene View to Main Camera");
                mainCamera.transform.position = sceneCamera.transform.position;
                mainCamera.transform.rotation = sceneCamera.transform.rotation;
                Debug.Log("메인 카메라 위치와 회전이 씬 뷰 카메라와 동기화되었습니다.");
            }
            else
            {
                Debug.LogError("메인 카메라를 찾을 수 없습니다.");
            }
        }
        else
        {
            Debug.LogError("씬 뷰 카메라를 찾을 수 없습니다.");
        }
    }
}
