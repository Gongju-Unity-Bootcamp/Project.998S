public class UISubItem : UserInterface
{
    /// <summary>
    /// �������̽� ��� ������ ���� �޼ҵ��Դϴ�.
    /// </summary>
    public override void Init()
    {
        base.Init();
    }

    /// <summary>
    /// �������̽� ��� ���Ḧ ���� �޼ҵ��Դϴ�.
    /// </summary>
    public virtual void CloseSubItem() 
        => Managers.Resource.Destroy(gameObject);
}