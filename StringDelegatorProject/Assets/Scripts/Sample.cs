using UnityEngine;
using com.amabie.StringDelegator;
using System;
using ANamespace;

public class Sample : MonoBehaviour
{
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;

    void Start()
    {
        UnityEngine.Debug.Log("-- 正常系 --");
        a.ToFunc<bool>(Type.GetType("ANamespace.AScript"), "Func")();
        a.ToAction(Type.GetType("ANamespace.AScript"), "Action")();
        UnityEngine.Debug.LogWarning("-- 異常系 --");
        UnityEngine.Debug.LogWarning("--- type instance error ---");
        try
        {
            a.ToFunc<bool>(Type.GetType("AScript"), "Func")();
        }
        catch (StringDelegatorException e) {
            UnityEngine.Debug.LogError(e);
        }
        try
        {
            a.ToAction(Type.GetType("AScript"), "Action")();
        }
        catch (StringDelegatorException e)
        {
            UnityEngine.Debug.LogError(e);
        }
        UnityEngine.Debug.LogWarning("--- method string error ---");
        try
        {
            a.ToFunc<bool>(Type.GetType("ANamespace.AScript"), "Dummy")();
        }
        catch (StringDelegatorException e)
        {
            UnityEngine.Debug.LogError(e);
        }
        try
        {
            a.ToAction(Type.GetType("ANamespace.AScript"), "Dummy")();
        }
        catch (StringDelegatorException e)
        {
            UnityEngine.Debug.LogError(e);
        }
        UnityEngine.Debug.LogWarning("--- type parameter error ---");
        try
        {
            a.ToFunc<string>(Type.GetType("ANamespace.AScript"), "Func")();
        }
        catch (StringDelegatorException e)
        {
            UnityEngine.Debug.LogError(e);
        }
        UnityEngine.Debug.LogWarning("--- gameObj does not have component error ---");
        try
        {
            b.ToFunc<bool>(Type.GetType("ANamespace.AScript"), "Func")();
        }
        catch (StringDelegatorException e)
        {
            UnityEngine.Debug.LogError(e);
        }
        try
        {
            b.ToAction(Type.GetType("ANamespace.AScript"), "Action")();
        }
        catch (StringDelegatorException e)
        {
            UnityEngine.Debug.LogError(e);
        }
    }
}