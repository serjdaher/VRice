//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;
//public class TwoHandGrabInteractable : XRGrabInteractable
//{
//    public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();
//    private XRBaseInteractor secondInteractor;
//    // Start is called before the first frame update
//    [System.Obsolete]
//    void Start()
//    {
//        foreach(var item in secondHandGrabPoints)
//        {
//            item.onSelectEnter.AddListener(OnSecondHandGrab);
//            item.onSelectExit.AddListener(OnSecondHandRelease);
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    [System.Obsolete]
//#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
//    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
//#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
//    {
//        if(secondInteractor && selectingInteractor)
//        {
//            // Compute the rotation
//            selectingInteractor.attachTransform.rotation = Quaternion.LookRotation(secondInteractor.attachTransform.position - selectingInteractor.attachTransform.position);
//        }
//        base.ProcessInteractable(updatePhase);
//    }

//    public void OnSecondHandGrab(XRBaseInteractor interactor)
//    {
//        Debug.Log("SECOND HAND GRAB");
//        secondInteractor = interactor;
//    }

//    public void OnSecondHandRelease(XRBaseInteractor interactor)
//    {
//        Debug.Log("SECOND HAND RELEASE");
//        secondInteractor = null;
//    }

//    [System.Obsolete]
//    protected override void OnSelectEntered(XRBaseInteractor interactor)
//    {
//        base.OnSelectEntered(interactor);
//        Debug.Log("FIRST GRAB ENTER");
//    }

//    [System.Obsolete]
//    protected override void OnSelectExited(XRBaseInteractor interactor)
//    {
//        base.OnSelectExited(interactor);
//        Debug.Log("FIRST GRAB EXIT");
//        secondInteractor = null;
//    }

//    [System.Obsolete]
//    public override bool IsSelectableBy(XRBaseInteractor interactor)
//    {
//        bool isalreadygrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
//        return base.IsSelectableBy(interactor) && !isalreadygrabbed;
//    }
//}
