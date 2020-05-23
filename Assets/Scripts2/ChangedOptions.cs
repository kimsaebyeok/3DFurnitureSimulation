using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangedOptions : MonoBehaviour
{
    public List<Dropdown.OptionData> optionsDo = new List<Dropdown.OptionData>();
    public List<Dropdown.OptionData> optionsSi = new List<Dropdown.OptionData>();
    public Dropdown dropdownDo;
    public Dropdown dropdownSi;
    // Start is called before the first frame update
    void Start()
    {
        setDropdownOptionsExample();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setDropdownOptionsExample()
    {
        dropdownDo.options.Clear();
        dropdownSi.options.Clear();

        optionsDo.Add(new Dropdown.OptionData("경기도"));
        optionsDo.Add(new Dropdown.OptionData("전라남도"));
        optionsDo.Add(new Dropdown.OptionData("전라북도"));
        optionsDo.Add(new Dropdown.OptionData("충청남도"));
        optionsDo.Add(new Dropdown.OptionData("충청북도"));
        optionsDo.Add(new Dropdown.OptionData("강원도"));
        optionsDo.Add(new Dropdown.OptionData("경상남도"));
        optionsDo.Add(new Dropdown.OptionData("경상북도"));
        dropdownDo.options = optionsDo;

        optionsSi.Add(new Dropdown.OptionData("가평군"));
        optionsSi.Add(new Dropdown.OptionData("고양시"));
        optionsSi.Add(new Dropdown.OptionData("과천시"));
        optionsSi.Add(new Dropdown.OptionData("광명시"));
        optionsSi.Add(new Dropdown.OptionData("광주시"));
        optionsSi.Add(new Dropdown.OptionData("구리시"));
        optionsSi.Add(new Dropdown.OptionData("군포시"));
        optionsSi.Add(new Dropdown.OptionData("김포시"));
        optionsSi.Add(new Dropdown.OptionData("남양주시"));
        optionsSi.Add(new Dropdown.OptionData("동두천시"));
        optionsSi.Add(new Dropdown.OptionData("부천시"));
        optionsSi.Add(new Dropdown.OptionData("성남시"));
        optionsSi.Add(new Dropdown.OptionData("수원시"));
        optionsSi.Add(new Dropdown.OptionData("시흥시"));
        optionsSi.Add(new Dropdown.OptionData("안산시"));
        optionsSi.Add(new Dropdown.OptionData("안서시"));
        optionsSi.Add(new Dropdown.OptionData("안양시"));
        optionsSi.Add(new Dropdown.OptionData("양주시"));
        optionsSi.Add(new Dropdown.OptionData("양평군"));
        optionsSi.Add(new Dropdown.OptionData("여주시"));
        optionsSi.Add(new Dropdown.OptionData("연천군"));
        optionsSi.Add(new Dropdown.OptionData("오산시"));
        optionsSi.Add(new Dropdown.OptionData("용인시"));
        optionsSi.Add(new Dropdown.OptionData("의왕시"));
        optionsSi.Add(new Dropdown.OptionData("의정부시"));
        optionsSi.Add(new Dropdown.OptionData("이천시"));
        optionsSi.Add(new Dropdown.OptionData("파주시"));
        optionsSi.Add(new Dropdown.OptionData("평택시"));
        optionsSi.Add(new Dropdown.OptionData("포천시"));
        optionsSi.Add(new Dropdown.OptionData("하남시"));
        optionsSi.Add(new Dropdown.OptionData("화성시"));
        dropdownSi.options = optionsSi;
    }
    
    public void OnValueChanged()
    {
        if (dropdownDo.value == 0)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("가평군"));
            optionsSi.Add(new Dropdown.OptionData("고양시"));
            optionsSi.Add(new Dropdown.OptionData("과천시"));
            optionsSi.Add(new Dropdown.OptionData("광명시"));
            optionsSi.Add(new Dropdown.OptionData("광주시"));
            optionsSi.Add(new Dropdown.OptionData("구리시"));
            optionsSi.Add(new Dropdown.OptionData("군포시"));
            optionsSi.Add(new Dropdown.OptionData("김포시"));
            optionsSi.Add(new Dropdown.OptionData("남양주시"));
            optionsSi.Add(new Dropdown.OptionData("동두천시"));
            optionsSi.Add(new Dropdown.OptionData("부천시"));
            optionsSi.Add(new Dropdown.OptionData("성남시"));
            optionsSi.Add(new Dropdown.OptionData("수원시"));
            optionsSi.Add(new Dropdown.OptionData("시흥시"));
            optionsSi.Add(new Dropdown.OptionData("안산시"));
            optionsSi.Add(new Dropdown.OptionData("안서시"));
            optionsSi.Add(new Dropdown.OptionData("안양시"));
            optionsSi.Add(new Dropdown.OptionData("양주시"));
            optionsSi.Add(new Dropdown.OptionData("양평군"));
            optionsSi.Add(new Dropdown.OptionData("여주시"));
            optionsSi.Add(new Dropdown.OptionData("연천군"));
            optionsSi.Add(new Dropdown.OptionData("오산시"));
            optionsSi.Add(new Dropdown.OptionData("용인시"));
            optionsSi.Add(new Dropdown.OptionData("의왕시"));
            optionsSi.Add(new Dropdown.OptionData("의정부시"));
            optionsSi.Add(new Dropdown.OptionData("이천시"));
            optionsSi.Add(new Dropdown.OptionData("파주시"));
            optionsSi.Add(new Dropdown.OptionData("평택시"));
            optionsSi.Add(new Dropdown.OptionData("포천시"));
            optionsSi.Add(new Dropdown.OptionData("하남시"));
            optionsSi.Add(new Dropdown.OptionData("화성시"));
            dropdownSi.options = optionsSi;
        }
        else if (dropdownDo.value == 1)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("목포시"));
            optionsSi.Add(new Dropdown.OptionData("여수시"));
            optionsSi.Add(new Dropdown.OptionData("순천시"));
            optionsSi.Add(new Dropdown.OptionData("나주시"));
            optionsSi.Add(new Dropdown.OptionData("광양시"));
            optionsSi.Add(new Dropdown.OptionData("담양군"));
            optionsSi.Add(new Dropdown.OptionData("곡성군"));
            optionsSi.Add(new Dropdown.OptionData("구례군"));
            optionsSi.Add(new Dropdown.OptionData("고흥군"));
            optionsSi.Add(new Dropdown.OptionData("보성군"));
            optionsSi.Add(new Dropdown.OptionData("화순군"));
            optionsSi.Add(new Dropdown.OptionData("장흥군"));
            optionsSi.Add(new Dropdown.OptionData("강진군"));
            optionsSi.Add(new Dropdown.OptionData("해남군"));
            optionsSi.Add(new Dropdown.OptionData("영암군"));
            optionsSi.Add(new Dropdown.OptionData("무안군"));
            optionsSi.Add(new Dropdown.OptionData("함평군"));
            optionsSi.Add(new Dropdown.OptionData("영광군"));
            optionsSi.Add(new Dropdown.OptionData("장성군"));
            optionsSi.Add(new Dropdown.OptionData("완도군"));
            optionsSi.Add(new Dropdown.OptionData("진도군"));
            optionsSi.Add(new Dropdown.OptionData("신안군"));
            dropdownSi.options = optionsSi;
        }
        else if (dropdownDo.value == 2)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("전주시"));
            optionsSi.Add(new Dropdown.OptionData("익산시"));
            optionsSi.Add(new Dropdown.OptionData("군산시"));
            optionsSi.Add(new Dropdown.OptionData("정읍시"));
            optionsSi.Add(new Dropdown.OptionData("김제시"));
            optionsSi.Add(new Dropdown.OptionData("남원시"));
            optionsSi.Add(new Dropdown.OptionData("완주군"));
            optionsSi.Add(new Dropdown.OptionData("고창군"));
            optionsSi.Add(new Dropdown.OptionData("부안군"));
            optionsSi.Add(new Dropdown.OptionData("임실군"));
            optionsSi.Add(new Dropdown.OptionData("순창군"));
            optionsSi.Add(new Dropdown.OptionData("진안군"));
            optionsSi.Add(new Dropdown.OptionData("무주군"));
            optionsSi.Add(new Dropdown.OptionData("장수군"));
            dropdownSi.options = optionsSi;
        }
        else if (dropdownDo.value == 3)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("천안시"));
            optionsSi.Add(new Dropdown.OptionData("공주시"));
            optionsSi.Add(new Dropdown.OptionData("보령시"));
            optionsSi.Add(new Dropdown.OptionData("아산시"));
            optionsSi.Add(new Dropdown.OptionData("서산시"));
            optionsSi.Add(new Dropdown.OptionData("논산시"));
            optionsSi.Add(new Dropdown.OptionData("계룡시"));
            optionsSi.Add(new Dropdown.OptionData("당진시"));
            optionsSi.Add(new Dropdown.OptionData("금산군"));
            optionsSi.Add(new Dropdown.OptionData("부여군"));
            optionsSi.Add(new Dropdown.OptionData("서천군"));
            optionsSi.Add(new Dropdown.OptionData("청양군"));
            optionsSi.Add(new Dropdown.OptionData("홍성군"));
            optionsSi.Add(new Dropdown.OptionData("예산군"));
            optionsSi.Add(new Dropdown.OptionData("태안군"));
            dropdownSi.options = optionsSi;
        }
        else if (dropdownDo.value == 4)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("청주시"));
            optionsSi.Add(new Dropdown.OptionData("충주시"));
            optionsSi.Add(new Dropdown.OptionData("제천시"));
            optionsSi.Add(new Dropdown.OptionData("보은군"));
            optionsSi.Add(new Dropdown.OptionData("옥천군"));
            optionsSi.Add(new Dropdown.OptionData("영동군"));
            optionsSi.Add(new Dropdown.OptionData("증평군"));
            optionsSi.Add(new Dropdown.OptionData("진천군"));
            optionsSi.Add(new Dropdown.OptionData("괴산군"));
            optionsSi.Add(new Dropdown.OptionData("음성군"));
            optionsSi.Add(new Dropdown.OptionData("담양군"));
            dropdownSi.options = optionsSi;
        }
        else if (dropdownDo.value == 5)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("원주시"));
            optionsSi.Add(new Dropdown.OptionData("춘천시"));
            optionsSi.Add(new Dropdown.OptionData("강릉시"));
            optionsSi.Add(new Dropdown.OptionData("동해시"));
            optionsSi.Add(new Dropdown.OptionData("속초시"));
            optionsSi.Add(new Dropdown.OptionData("삼척시"));
            optionsSi.Add(new Dropdown.OptionData("태백시"));
            optionsSi.Add(new Dropdown.OptionData("홍천군"));
            optionsSi.Add(new Dropdown.OptionData("철원군"));
            optionsSi.Add(new Dropdown.OptionData("횡성군"));
            optionsSi.Add(new Dropdown.OptionData("평창군"));
            optionsSi.Add(new Dropdown.OptionData("정선군"));
            optionsSi.Add(new Dropdown.OptionData("영월군"));
            optionsSi.Add(new Dropdown.OptionData("인제군"));
            optionsSi.Add(new Dropdown.OptionData("고성군"));
            optionsSi.Add(new Dropdown.OptionData("양양군"));
            optionsSi.Add(new Dropdown.OptionData("화천군"));
            optionsSi.Add(new Dropdown.OptionData("양구군"));
            dropdownSi.options = optionsSi;
        }
        if (dropdownDo.value == 6)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("창원시"));
            optionsSi.Add(new Dropdown.OptionData("김해시"));
            optionsSi.Add(new Dropdown.OptionData("진주시"));
            optionsSi.Add(new Dropdown.OptionData("양산시"));
            optionsSi.Add(new Dropdown.OptionData("거제시"));
            optionsSi.Add(new Dropdown.OptionData("통영시"));
            optionsSi.Add(new Dropdown.OptionData("사천시"));
            optionsSi.Add(new Dropdown.OptionData("밀양시"));
            optionsSi.Add(new Dropdown.OptionData("함안군"));
            optionsSi.Add(new Dropdown.OptionData("거창군"));
            optionsSi.Add(new Dropdown.OptionData("창녕군"));
            optionsSi.Add(new Dropdown.OptionData("고성군"));
            optionsSi.Add(new Dropdown.OptionData("하동군"));
            optionsSi.Add(new Dropdown.OptionData("합천군"));
            optionsSi.Add(new Dropdown.OptionData("남해군"));
            optionsSi.Add(new Dropdown.OptionData("함양군"));
            optionsSi.Add(new Dropdown.OptionData("산청군"));
            optionsSi.Add(new Dropdown.OptionData("의령군"));
            dropdownSi.options = optionsSi;
        }
        if (dropdownDo.value == 7)
        {
            optionsSi.Clear();
            optionsSi.Add(new Dropdown.OptionData("포항시"));
            optionsSi.Add(new Dropdown.OptionData("경주시"));
            optionsSi.Add(new Dropdown.OptionData("김천시"));
            optionsSi.Add(new Dropdown.OptionData("안동시"));
            optionsSi.Add(new Dropdown.OptionData("구미시"));
            optionsSi.Add(new Dropdown.OptionData("영주시"));
            optionsSi.Add(new Dropdown.OptionData("영천시"));
            optionsSi.Add(new Dropdown.OptionData("상주시"));
            optionsSi.Add(new Dropdown.OptionData("문경시"));
            optionsSi.Add(new Dropdown.OptionData("경산시"));
            optionsSi.Add(new Dropdown.OptionData("군위군"));
            optionsSi.Add(new Dropdown.OptionData("의성군"));
            optionsSi.Add(new Dropdown.OptionData("청송군"));
            optionsSi.Add(new Dropdown.OptionData("영양군"));
            optionsSi.Add(new Dropdown.OptionData("영덕군"));
            optionsSi.Add(new Dropdown.OptionData("청도군"));
            optionsSi.Add(new Dropdown.OptionData("고령군"));
            optionsSi.Add(new Dropdown.OptionData("성주군"));
            optionsSi.Add(new Dropdown.OptionData("칠곡군"));
            optionsSi.Add(new Dropdown.OptionData("예천군"));
            optionsSi.Add(new Dropdown.OptionData("봉화군"));
            optionsSi.Add(new Dropdown.OptionData("울진군"));
            optionsSi.Add(new Dropdown.OptionData("울릉군"));
            dropdownSi.options = optionsSi;
        }
    }
}
