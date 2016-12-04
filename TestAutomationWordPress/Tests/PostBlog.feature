Feature: PostBlog

@addnewpost
Scenario: Add New Post
	Given I am in All Post Page
	When I click Add New Button
	Then the Add New Post Page appears
	When I enter title
	And I enter content
	Then Permanent Link appear
	When I click Publish
	Then Edit Post Page appear
	When I am in All Post Page
	Then new Post display in grid
