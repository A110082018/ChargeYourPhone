using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{

    public int m_seconds;                 //�˼ƭp�ɸg���⪺�`���

    public int m_min;              //�Ω�]�w�˼ƭp�ɪ�����
    public int m_sec;              //�Ω�]�w�˼ƭp�ɪ����

    public float hp = 600;
    public float maxHP = 600;

    public Image batteryHPbar;
    public Text m_timer;           //�]�w�e���˼ƭp�ɪ���r
    public GameObject m_gameOver;  //�]�w GAME OVER ����

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Countdown", 0.0f, 1.0f);
    }

    //IEnumerator Countdown()
    //{
    //    m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));

    //    //hp -= 120; //��q�q

    //    //����hp bar
    //    //float sy = hp / maxHP;
    //    //batteryHPbar.rectTransform.localScale = new Vector3(1, sy, 1);


    //    m_seconds = (m_min * 60) + m_sec;       //�N�ɶ����⬰���

    //    while (m_seconds > 0)                   //�p�G�ɶ��|������
    //    {
    //        //yield return new WaitForSeconds(1); //���Ԥ@��A������

    //        m_seconds--;                        //�`��ƴ� 1
    //        m_sec--;                            //�N��ƴ� 1

    //        if (m_sec < 0 && m_min > 0)         //�p�G��Ƭ� 0 �B�����j�� 0
    //        {
    //            m_min -= 1;                     //���N������h 1
    //            m_sec = 59;                     //�A�N��Ƴ]�� 59
    //        }
    //        else if (m_sec < 0 && m_min == 0)   //�p�G��Ƭ� 0 �B�����j�� 0
    //        {
    //            m_sec = 0;                      //�]�w��Ƶ��� 0
    //        }

    //        //yield return new WaitForSeconds(1);   //�ɶ������ɡA��� 00:00 ���d�@��
    //        m_gameOver.SetActive(true);           //�ɶ������ɡA�e���X�{ GAME OVER
    //        Time.timeScale = 0;                   //�ɶ������ɡA����C���Ȱ��L�k�ާ@

    //    }
    //    yield return new WaitForSeconds(1); //���Ԥ@��A������


    //}

    private void Countdown()
    {
        m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));

        hp -= 1; //��q�q

        //����hp bar
        float sy = hp / maxHP;
        batteryHPbar.rectTransform.localScale = new Vector3(1, sy, 1);


        m_seconds = (m_min * 60) + m_sec;       //�N�ɶ����⬰���

        if (m_seconds > 0)                   //�p�G�ɶ��|������
        {
            //yield return new WaitForSeconds(1); //���Ԥ@��A������

            m_seconds--;                        //�`��ƴ� 1
            m_sec--;                            //�N��ƴ� 1

            if (m_sec < 0 && m_min > 0)         //�p�G��Ƭ� 0 �B�����j�� 0
            {
                m_min -= 1;                     //���N������h 1
                m_sec = 59;                     //�A�N��Ƴ]�� 59
            }
            else if (m_sec < 0 && m_min == 0)   //�p�G��Ƭ� 0 �B�����j�� 0
            {
                m_sec = 0;                      //�]�w��Ƶ��� 0
            }
        }
        else
        {   //�ɶ������ɡA��� 00:00 ���d�@��
            m_gameOver.SetActive(true);           //�ɶ������ɡA�e���X�{ GAME OVER
            Time.timeScale = 0;                   //�ɶ������ɡA����C���Ȱ��L�k�ާ@

        }


    }



    // Update is called once per frame
    void Update()
    {

    }
}

