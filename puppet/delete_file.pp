file { 'C:/demo/test_file.txt':
    ensure => absent,
}

file { 'C:/demo':
    ensure => absent,
    force => true,
    recurse => true,
    purge => true,
}
