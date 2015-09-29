file { 'C:/demo':
    ensure => directory,
    owner => 'Kyle',
}

file { 'C:/demo/test_file.txt':
    ensure => present,
    owner => 'Kyle',
    group => 'Administrators',
    source => 'C:/test_file.txt',
}
