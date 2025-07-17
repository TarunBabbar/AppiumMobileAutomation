Feature: Main Menu Navigation
  As a user
  I want to be able to navigate and click all main menu links in the ApiDemos app
  So that I can verify each menu is accessible

  Scenario: Navigate and click all main menu links
    Given the app is launched
    When I navigate and click all main menu links
    Then all main menu links should be accessible
