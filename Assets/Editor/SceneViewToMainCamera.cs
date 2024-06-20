using UnityEditor;
using UnityEngine;

public class SceneViewToMainCamera : EditorWindow
{
    [MenuItem("Tools/Sync Scene View to Main Camera")]
    public static void SyncSceneViewToMainCamera()
    {
        // �� �並 �����ɴϴ�.
        SceneView sceneView = SceneView.lastActiveSceneView;
        if (sceneView != null && sceneView.camera != null)
        {
            // �� �� ī�޶��� ��ġ�� ȸ���� �����ɴϴ�.
            Camera sceneCamera = sceneView.camera;

            // ���� ī�޶� ã�Ƽ� ��ġ�� ȸ���� �����մϴ�.
            Camera mainCamera = Camera.main;
            if (mainCamera != null)
            {
                Undo.RecordObject(mainCamera.transform, "Sync Scene View to Main Camera");
                mainCamera.transform.position = sceneCamera.transform.position;
                mainCamera.transform.rotation = sceneCamera.transform.rotation;
                Debug.Log("���� ī�޶� ��ġ�� ȸ���� �� �� ī�޶�� ����ȭ�Ǿ����ϴ�.");
            }
            else
            {
                Debug.LogError("���� ī�޶� ã�� �� �����ϴ�.");
            }
        }
        else
        {
            Debug.LogError("�� �� ī�޶� ã�� �� �����ϴ�.");
        }
    }
}
