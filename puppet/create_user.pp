user { 'test_user':
    ensure => present,
    name => 'test_user',
    comment => 'Test user for testing',
    groups => 'Administrators',
    home => 'C:\Users\test_user',
    managehome => true,
    password => 'SomePassword1'
}
