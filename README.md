박홍근 포트폴리오

소개
  C# / MES UI 개발 9년 5개월 경력의 박홍근 포트폴리오입니다.

-----------------------------------------------------------------------------------------------------------

프로젝트 1 — 수출입 화물 관리 시스템 (ASPWeb, ASPWebWindow)
  개요
    DevExpress UI 라이브러리를 활용한 세관 신고 관리 시스템입니다.
    수출입 화물의 신고 접수부터 통관 완료까지의 업무 프로세스를 구현했습니다.
    
    기술 스택
      구분기술 Frontend : C#, .NET 8, WinForms, DevExpress
              Backend : ASP.NET Core Web API
              Database : MS-SQL (PortfolioDB) 아키텍처 Controller → Service → Repository
            
    주요 기능
      신고 접수 — 수출입 화물 신고 등록
      신고 수정 — 기존 신고 내용 수정 및 이력 관리
      신고 취소 — 신고 취소 및 취소 이력 저장
      통관 조회 — DevExpress GridControl 기반 목록 조회
      세금 계산 — HS코드 기반 관세 자동 계산 및 DevExpress Report 출력
    
    시스템 구조
      WinForms (Frontend)
          ↕ HTTP (REST API)
      ASP.NET Core Web API (Backend)
          ↕ Dapper
      MS-SQL (Database)

-----------------------------------------------------------------------------------------------------------

  프로젝트 2 - MES 시스템 (PortfolioProject)
    개요
      9년 5개월간 반도체 제조 현장에서 구축해온 MES(Manufacturing Execution System) 경험을 바탕으로 핵심 기능을 구현한 프로젝트입니다. 현재 개발 진행 중이며 지속적으로 업데이트될 예정입니다.
      
    구현 예정 기능
      모듈    설명                                상태
      SPC     통계적 공정 관리 차트 및 데이터 분석  개발중
      WCS     창고 제어 시스템                     예정
      WMS     창고 관리 시스템                     예정

    SPC 우선 구현 이유
      SPC(Statistical Process Control)는 제조 공정의 품질 관리를 위한 핵심 모듈로, Chart 컨트롤을 활용한 데이터 시각화와 UCL/LCL 기반 공정 이상 감지 로직을 중점적으로 구현하고 있습니다.
      
    기술 스택
      Language : C#.NET 8
      UI       : WinForms
      Database : Oracle

-----------------------------------------------------------------------------------------------------------
